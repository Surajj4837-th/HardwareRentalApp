using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HardwareRentalApp.Classes
{
    internal class DBInterface
    {
        private readonly string ConnectionString;
        public DBInterface()
        {
            ConnectionString = GetConnectionString();
        }

        private string GetConnectionString()
        {
            string raw = ConfigurationManager.ConnectionStrings["HardwareRentalAppConnection"].ConnectionString;

            // Detect if running under Visual Studio debugger, even in Release
            if (System.Diagnostics.Debugger.IsAttached)
            {
                string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
                string DatabasePath = Path.Combine(solutionDir, ConfigurationManager.AppSettings["DevelopmentPath"]);
                //string DatabasePath = Path.Combine(AppContext.BaseDirectory, ConfigurationManager.AppSettings["DevelopmentPath"]);
                return raw.Replace("|DataDirectory|", DatabasePath);
            }
            else
            {
                string DatabasePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    ConfigurationManager.AppSettings["InstalledPath"]
                );
                return raw.Replace("|DataDirectory|", DatabasePath);
            }
        }


        /// <summary>
        /// Creates and returns a new SQL connection.
        /// </summary>
        private SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /// <summary>
        /// Executes a non-query command (INSERT, UPDATE, DELETE).
        /// </summary>
        public int ExecuteQuery(SqlCommand dbCommand)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    dbCommand.Connection = conn;
                    dbCommand.CommandType = CommandType.Text;

                    return dbCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                throw; // preserve stack trace
            }
        }

        /// <summary>
        ///     Used for select queries that return multiple rows.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="mapFunc"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> ExecuteQuery<T>(string query, Func<SqlDataReader, T> mapFunc,  params SqlParameter[] parameters)
        {
            var results = new List<T>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(mapFunc(reader));
                    }
                }
            }

            return results;
        }

        /// <summary>
        ///     Used for insert, update or delete queries
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                conn.Open();
                return cmd.ExecuteNonQuery(); // returns # of rows affected
            }
        }


        /// <summary>
        /// Executes a scalar query and returns a single value.
        /// </summary>
        public object ExecuteScalarQuery(SqlCommand dbCommand)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    dbCommand.Connection = conn;
                    dbCommand.CommandType = CommandType.Text;

                    return dbCommand.ExecuteScalar();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Executes a SELECT query and fills the provided DataTable.
        /// </summary>
        public void ReadDataThroughAdapter(string query, DataTable tblName, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = CommandType.Text;

                        // Add each parameter from the dictionary
                        if (parameters != null)
                        {
                            foreach (var kvp in parameters)
                            {
                                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(tblName);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
