using HardwareRentalApp.Classes;
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
    public partial class Sale : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Sale).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();

        public Sale()
        {
            InitializeComponent();
            List<Items> items = GetLocalizedItems();
            LoadData(items);
        }

        private void LoadData(List<Items> items)
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
            DataTable dt_items = new DataTable();
            dt_items.Columns.Add("ItemId", typeof(int));
            dt_items.Columns.Add("LocalizedName", typeof(string));
            dt_items.Columns.Add("Rent", typeof(decimal));
            dt_items.Columns.Add("Quantity", typeof(int));

            foreach (var item in items)
            {
                dt_items.Rows.Add(item.ItemId, item.LocalizedName, item.Rent, 0); // start with 0 qty
            }

            // Bind to DataGridView
            dgv_Sale.DataSource = dt_items;

            AdjustGridHeight();
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

            dgv_Sale.Height = totalHeight + 8;  //padding a small buffer
        }

        public List<Items> GetLocalizedItems()
        {
            string query = "SELECT ItemId, ItemName, Rent FROM Items";

            var items = obj_DBAccess.ExecuteQuery(query, reader => new Items
            {
                ItemId = reader.GetInt32(0),
                ItemName = reader.GetString(1),
                Rent = reader.GetDecimal(2)
            });

            LocalizeItems(items);
            return items;
        }

        private void LocalizeItems(List<Items> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                string localizedName = LangManager.GetString(
                    items[i].ItemName,
                    Thread.CurrentThread.CurrentUICulture
                );

                var item = items[i];
                item.LocalizedName = string.IsNullOrEmpty(localizedName)
                                        ? item.ItemName
                                        : localizedName;
                items[i] = item;
            }
        }

        public int CreateBill(
    int customerId,
    int adminId,
    DateTime rentalStart,
    DateTime? rentalEnd,
    string projectOwner,
    string reference,
    string workLocation,
    DateTime? paymentDate,
    decimal totalAmount,
    decimal advanceAmount,
    List<(int ItemId, int Quantity, decimal Price)> items)
        {
            // 1. Insert Bill and get BillId
            var billCmd = new SqlCommand(@"
        INSERT INTO Bills (
            CustomerId, AdminId, RentalStartDate, RentalEndDate,
            ProjectOwner, Reference, WorkLocation,
            PaymentDate, TotalAmount, AdvanceAmount, IsPaid
        )
        OUTPUT INSERTED.BillId
        VALUES (
            @CustomerId, @AdminId, @RentalStartDate, @RentalEndDate,
            @ProjectOwner, @Reference, @WorkLocation,
            @PaymentDate, @TotalAmount, @AdvanceAmount,
            CASE WHEN @PaymentDate IS NULL THEN 0 ELSE 1 END
        )");

            billCmd.Parameters.AddWithValue("@CustomerId", customerId);
            billCmd.Parameters.AddWithValue("@AdminId", adminId);
            billCmd.Parameters.AddWithValue("@RentalStartDate", rentalStart);
            billCmd.Parameters.AddWithValue("@RentalEndDate", (object?)rentalEnd ?? DBNull.Value);
            billCmd.Parameters.AddWithValue("@ProjectOwner", projectOwner);
            billCmd.Parameters.AddWithValue("@Reference", reference);
            billCmd.Parameters.AddWithValue("@WorkLocation", string.IsNullOrWhiteSpace(workLocation) ? DBNull.Value : (object)workLocation);
            billCmd.Parameters.AddWithValue("@PaymentDate", (object?)paymentDate ?? DBNull.Value);
            billCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
            billCmd.Parameters.AddWithValue("@AdvanceAmount", advanceAmount);

            int billId = Convert.ToInt32(obj_DBAccess.ExecuteScalarQuery(billCmd));

            // 2. Insert Bill Items
            foreach (var item in items)
            {
                var itemCmd = new SqlCommand(@"
            INSERT INTO BillItems (BillId, ItemId, Quantity, Price)
            VALUES (@BillId, @ItemId, @Quantity, @Price)");

                itemCmd.Parameters.AddWithValue("@BillId", billId);
                itemCmd.Parameters.AddWithValue("@ItemId", item.ItemId);
                itemCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                itemCmd.Parameters.AddWithValue("@Price", item.Price);

                obj_DBAccess.ExecuteQuery(itemCmd);
            }

            return billId;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
