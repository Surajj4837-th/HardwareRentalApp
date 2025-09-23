using HardwareRentalApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
