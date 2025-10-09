using HardwareRentalApp.Classes;
using HardwareRentalApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareRentalApp.Forms
{
    public partial class Bill : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Sale).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();
        private List<Items> l_items;          // List to hold items fetched from DB
        List<BillSummary> BillInformation;
        DataTable dt_items = new DataTable();       //List of items to be written to bill db from DGV input
        private int BillID;

        public Bill(int invoiceID)
        {
            InitializeComponent();

            BillID = invoiceID;

            GetLocalizedItems();
            LoadData();
            FillFormDetails();
        }

        private void FillFormDetails()
        {
            tb_LesseeName.Text = BillInformation[0].CustomerName;
            tb_OwnerName.Text = BillInformation[0].OwnerName;
            tb_Reference.Text = BillInformation[0].Reference;
            tb_WorkLocation.Text = BillInformation[0].WorkLocation;
            tb_StartRentDate.Text = BillInformation[0].BillDate.ToString();
        }

        private void LoadData()
        {
            //Get bill information
            var billIdParam = new SqlParameter("@BillId", SqlDbType.BigInt) { Value = BillID };

            BillInformation = obj_DBAccess.ExecuteQuery(
                    @"SELECT 
                    B.CustomerId,
                    C.LesseeName,
                    B.BillDate,
                    B.ProjectOwner,
                    B.Reference,
                    B.WorkLocation
                  FROM Bills B
                  JOIN Customers C ON B.CustomerId = C.CustomerId
                  WHERE B.BillId = @BillId",
                r => new BillSummary
                {
                    CustomerId = r.IsDBNull(r.GetOrdinal("CustomerId")) ? 0 : r.GetInt32(r.GetOrdinal("CustomerId")),
                    CustomerName = r.IsDBNull(r.GetOrdinal("LesseeName")) ? string.Empty : r.GetString(r.GetOrdinal("LesseeName")),
                    BillDate = r.IsDBNull(r.GetOrdinal("BillDate")) ? DateTime.MinValue : r.GetDateTime(r.GetOrdinal("BillDate")),
                    OwnerName = r.IsDBNull(r.GetOrdinal("ProjectOwner")) ? string.Empty : r.GetString(r.GetOrdinal("ProjectOwner")),
                    Reference = r.IsDBNull(r.GetOrdinal("Reference")) ? string.Empty : r.GetString(r.GetOrdinal("Reference")),
                    WorkLocation = r.IsDBNull(r.GetOrdinal("WorkLocation")) ? string.Empty : r.GetString(r.GetOrdinal("WorkLocation"))
                },
                billIdParam
            );

            //Clear existing columns and set up DataGridView
            dgv_Sale.Columns.Clear();
            dgv_Sale.AutoGenerateColumns = false;

            // Add columns as per the list of items in the database
            dgv_Sale.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemId",
                DataPropertyName = "ItemId",
                HeaderText = LangManager.GetString("ItemID", Thread.CurrentThread.CurrentUICulture),
                ReadOnly = true
            });

            dgv_Sale.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LocalizedName",
                DataPropertyName = "LocalizedName",
                HeaderText = LangManager.GetString("ItemName", Thread.CurrentThread.CurrentUICulture),
                ReadOnly = true,
                Width = 200
            });
            dgv_Sale.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Rent",
                DataPropertyName = "Rent",
                HeaderText = LangManager.GetString("Rent", Thread.CurrentThread.CurrentUICulture),
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }  // Currency format
            });
            dgv_Sale.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityRented",
                DataPropertyName = "QuantityRented",
                HeaderText = LangManager.GetString("QuantityRented", Thread.CurrentThread.CurrentUICulture),
                Width = 80,
                ReadOnly = false
            });
            dgv_Sale.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityReturned",
                DataPropertyName = "QuantityReturned",
                HeaderText = LangManager.GetString("QuantityReturned", Thread.CurrentThread.CurrentUICulture),
                Width = 80,
                ReadOnly = false
            });

            // Create DataTable for binding
            dt_items.Columns.Add("ItemId", typeof(int));
            dt_items.Columns.Add("LocalizedName", typeof(string));
            dt_items.Columns.Add("Rent", typeof(decimal));
            dt_items.Columns.Add("QuantityRented", typeof(int));
            dt_items.Columns.Add("QuantityReturned", typeof(int));  // <<== important

            for (int i = 0; i < l_items.Count; i++)
            {
                var item = l_items[i];
                dt_items.Rows.Add(item.ItemId, item.LocalizedName, item.Rent, 0, 0); // start with 0 qty
            }

            AdjustGridHeight();

            //Query the bill items from DB
            billIdParam = new SqlParameter("@BillId", SqlDbType.BigInt) { Value = BillID };

            List<BillItemSummary> billItems = obj_DBAccess.ExecuteQuery(
                @"SELECT ItemId, Quantity, Price FROM BillItems WHERE BillId = @BillId",
                r => new BillItemSummary
                {
                    ItemId = r.GetInt32(r.GetOrdinal("ItemId")),
                    Quantity = r.GetInt32(r.GetOrdinal("Quantity")),
                    Price = r.GetDecimal(r.GetOrdinal("Price")),
                    ItemName = string.Empty // will fill below
                },
                billIdParam
            );

            foreach (DataRow itemRow in dt_items.Rows.Cast<DataRow>())
            {
                int itemId = Convert.ToInt32(itemRow["ItemId"]);

                // Find this item in billItems list
                var match = billItems.FirstOrDefault(bi => bi.ItemId == itemId);

                if (match != null)
                {
                    // If found, update quantity and amount
                    itemRow["QuantityRented"] = match.Quantity;
                }
                else
                {
                    // If item not part of this bill, reset to zero
                    itemRow["QuantityRented"] = 0;
                }
            }

            // Bind to DataGridView
            dgv_Sale.DataSource = dt_items;

            //make all cols except QuantityReturned read-only
            foreach (DataGridViewColumn col in dgv_Sale.Columns)
            {
                col.ReadOnly = col.Name != "QuantityReturned";  // all except this
            }

            dgv_Sale.Refresh();
        }

        private void AdjustGridHeight()
        {
            if (dgv_Sale.Rows.Count == 0)
                return;

            int totalHeight = dgv_Sale.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dgv_Sale.Rows)
            {
                if (row.IsNewRow) continue; // skip the blank new row if enabled
                totalHeight += row.Height;
            }

            dgv_Sale.Height = (totalHeight + 8) > dgv_Sale.Height ? dgv_Sale.Height : (totalHeight + 8);  //padding a small buffer
        }

        public void GetLocalizedItems()
        {
            string query = "SELECT ItemId, ItemName, Rent FROM Items";

            l_items = obj_DBAccess.ExecuteQuery(query, reader => new Items
            {
                ItemId = reader.GetInt32(0),
                ItemName = reader.GetString(1),
                Rent = reader.GetDecimal(2)
            },
            null);

            LocalizeItems();
        }

        private void LocalizeItems()
        {
            for (int i = 0; i < l_items.Count; i++)
            {
                string localizedName = LangManager.GetString(
                    l_items[i].ItemName,
                    Thread.CurrentThread.CurrentUICulture
                );

                var item = l_items[i];
                item.LocalizedName = string.IsNullOrEmpty(localizedName)
                                        ? item.ItemName
                                        : localizedName;
                l_items[i] = item;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Sale_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if we are in the "QuantityReturned" column
            if (dgv_Sale.Columns[e.ColumnIndex].Name == "QuantityReturned")
            {
                // Get the value from the "QuantityRented" cell in the same row
                var quantityRentedValue = dgv_Sale.Rows[e.RowIndex].Cells["QuantityRented"].Value;

                // Apply the same logic: check for null, parse to int, and check if > 0
                if (quantityRentedValue == null ||
                    !int.TryParse(quantityRentedValue.ToString(), out int quantityRented) ||
                    quantityRented <= 0)
                {
                    // If the condition is NOT met (i.e., the cell SHOULD be read-only), cancel the edit
                    e.Cancel = true;
                }
            }
        }
    }
}
