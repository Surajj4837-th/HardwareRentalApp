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
        }

        private void LoadData()
        {
            dgv_Sale.Columns.Clear();
            dgv_Sale.AutoGenerateColumns = false;

            // Add columns
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
                Name = "Quantity",
                DataPropertyName = "Quantity",
                HeaderText = LangManager.GetString("Quantity", Thread.CurrentThread.CurrentUICulture),
                Width = 80,
                ReadOnly = false
            });

            // Create DataTable for binding
            dt_items.Columns.Add("ItemId", typeof(int));
            dt_items.Columns.Add("LocalizedName", typeof(string));
            dt_items.Columns.Add("Rent", typeof(decimal));
            dt_items.Columns.Add("Quantity", typeof(int));

            for (int i = 0; i < l_items.Count; i++)
            {
                var item = l_items[i];
                dt_items.Rows.Add(item.ItemId, item.LocalizedName, item.Rent, 0); // start with 0 qty
            }

            // Bind to DataGridView
            dgv_Sale.DataSource = dt_items;

            AdjustGridHeight();

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
    }
}
