using HardwareRentalApp.Classes;
using QuestPDF.Fluent;
using System.Data;
using System.Data.SqlClient;
using System.Resources;

namespace HardwareRentalApp.Forms
{
    public partial class Bill : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Bill).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();
        private List<Items> l_items;          // List to hold items fetched from DB
        List<BillSummary> BillInformation;
        List<BillItemSummary> billItems;
        DataTable dt_items = new DataTable();       //List of items to be fetched from bill db to DGV input
        DataTable dt_NewBillItems = new DataTable();       //List of items to be written to bill db from DGV input after bill finalization
        private int BillID;
        private bool BillPaid = false;

        public Bill(int invoiceID)
        {
            InitializeComponent();

            BillID = invoiceID;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            GetLocalizedItems();

            LoadData();

            FillFormDetails();

            lbl_LesseeName.Text = LangManager.GetString("LesseeName");
            lbl_OwnerName.Text = LangManager.GetString("OwnerName");
            lbl_Reference.Text = LangManager.GetString("Reference");
            lbl_WorkLocation.Text = LangManager.GetString("WorkLocation");
            lbl_RentDate.Text = LangManager.GetString("RentDate");
            lbl_EndRentDate.Text = LangManager.GetString("EndRentDate");
            lbl_BillAmount.Text = LangManager.GetString("BillAmount");
        }

        private void FillFormDetails()
        {
            tb_LesseeName.Text = BillInformation[0].CustomerName;
            tb_OwnerName.Text = BillInformation[0].OwnerName;
            tb_Reference.Text = BillInformation[0].Reference;
            tb_WorkLocation.Text = BillInformation[0].WorkLocation;
            tb_StartRentDate.Text = BillInformation[0].BillDate.ToString();
            dtp_EndRentDate.MinDate = Convert.ToDateTime(BillInformation[0].BillDate.ToString()).Date;

            //Change form details if bill is already paid or not
            if (BillInformation[0].PaymentDate == DateTime.MinValue)
            {
                //Bill unpaid
                dtp_EndRentDate.Text = DateTime.Now.ToString();
                dtp_EndRentDate.Enabled = true;

                tb_BillAmount.Text = "0.0";

                dgv_Bill.Columns["QuantityReturned"].Visible = true;

                ComputeBill();

                lbl_main.Text = LangManager.GetString("PendingBill");

                BillPaid = false;

                btn_MultipurposeButton.Text = LangManager.GetString("FinishPurchase");
            }
            else
            {
                //Bill paid
                dtp_EndRentDate.Text = BillInformation[0].PaymentDate.ToString();
                dtp_EndRentDate.Enabled = false;

                tb_BillAmount.Text = BillInformation[0].TotalAmount.ToString("C2");

                dgv_Bill.Columns["QuantityReturned"].Visible = false;

                lbl_main.Text = LangManager.GetString("PaidBill");

                BillPaid = true;

                btn_MultipurposeButton.Enabled = true;

                btn_MultipurposeButton.Text = LangManager.GetString("GenerateBill");
            }
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
                    B.WorkLocation,
                    B.PaymentDate,
                    B.TotalAmount
                  FROM Bills B
                  JOIN Customers C ON B.CustomerId = C.CustomerId
                  WHERE B.BillId = @BillId",
                r => new BillSummary
                {
                    BillId = BillID,
                    CustomerId = r.IsDBNull(r.GetOrdinal("CustomerId")) ? 0 : r.GetInt32(r.GetOrdinal("CustomerId")),
                    CustomerName = r.IsDBNull(r.GetOrdinal("LesseeName")) ? string.Empty : r.GetString(r.GetOrdinal("LesseeName")),
                    BillDate = r.IsDBNull(r.GetOrdinal("BillDate")) ? DateTime.MinValue : r.GetDateTime(r.GetOrdinal("BillDate")),
                    OwnerName = r.IsDBNull(r.GetOrdinal("ProjectOwner")) ? string.Empty : r.GetString(r.GetOrdinal("ProjectOwner")),
                    Reference = r.IsDBNull(r.GetOrdinal("Reference")) ? string.Empty : r.GetString(r.GetOrdinal("Reference")),
                    WorkLocation = r.IsDBNull(r.GetOrdinal("WorkLocation")) ? string.Empty : r.GetString(r.GetOrdinal("WorkLocation")),
                    PaymentDate = r.IsDBNull(r.GetOrdinal("PaymentDate")) ? DateTime.MinValue : r.GetDateTime(r.GetOrdinal("PaymentDate")),
                    TotalAmount = r.IsDBNull(r.GetOrdinal("TotalAmount")) ? 0.0m : r.GetDecimal(r.GetOrdinal("TotalAmount"))
                },
                billIdParam
            );

            //Clear existing columns and set up DataGridView
            dgv_Bill.Columns.Clear();
            dgv_Bill.AutoGenerateColumns = false;

            // Add columns as per the list of items in the database
            dgv_Bill.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemId",
                DataPropertyName = "ItemId",
                HeaderText = LangManager.GetString("ItemID"),
                ReadOnly = true
            });

            dgv_Bill.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LocalizedName",
                DataPropertyName = "LocalizedName",
                HeaderText = LangManager.GetString("ItemName"),
                ReadOnly = true,
                Width = 200
            });
            dgv_Bill.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Rent",
                DataPropertyName = "Rent",
                HeaderText = LangManager.GetString("Rent"),
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }  // Currency format
            });
            dgv_Bill.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityRented",
                DataPropertyName = "QuantityRented",
                HeaderText = LangManager.GetString("QuantityRented"),
                Width = 80,
                ReadOnly = false
            });
            dgv_Bill.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RentalDays",
                DataPropertyName = "RentalDays",
                HeaderText = LangManager.GetString("RentalDays"),
                Width = 80,
                ReadOnly = false
            });
            dgv_Bill.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityReturned",
                DataPropertyName = "QuantityReturned",
                HeaderText = LangManager.GetString("QuantityReturned"),
                Width = 80,
                ReadOnly = false
            });

            // Create DataTable for binding
            dt_items.Columns.Add("ItemId", typeof(int));
            dt_items.Columns.Add("LocalizedName", typeof(string));
            dt_items.Columns.Add("Rent", typeof(decimal));
            dt_items.Columns.Add("QuantityRented", typeof(int));
            dt_items.Columns.Add("RentalDays", typeof(int));
            dt_items.Columns.Add("QuantityReturned", typeof(int));  // <<== important

            //Get the date difference for rental days
            int rentalDays = (dtp_EndRentDate.Value.Date - Convert.ToDateTime(BillInformation[0].BillDate.ToString()).Date).Days + 1; //Added +1 to count same day rent

            for (int i = 0; i < l_items.Count; i++)
            {
                var item = l_items[i];

                int ItemRentalDays = rentalDays;

                if (item.MinRentDays > rentalDays)
                {
                    ItemRentalDays = item.MinRentDays; //Ensure minimum rent days is considered
                }

                dt_items.Rows.Add(item.ItemId, item.LocalizedName, item.Rent, 0, ItemRentalDays, 0); // start with 0 qty
            }

            AdjustGridHeight();

            //Query the bill items from DB
            billIdParam = new SqlParameter("@BillId", SqlDbType.BigInt) { Value = BillID };

            billItems = obj_DBAccess.ExecuteQuery(
                @"SELECT ItemId, Quantity, Rent FROM BillItems WHERE BillId = @BillId",
                r => new BillItemSummary
                {
                    ItemId = r.GetInt32(r.GetOrdinal("ItemId")),
                    Quantity = r.GetInt32(r.GetOrdinal("Quantity")),
                    Rent = r.GetDecimal(r.GetOrdinal("Rent"))
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
                    itemRow["Rent"] = match.Rent;
                }
                else
                {
                    // If item not part of this bill, reset to zero
                    itemRow["QuantityRented"] = 0;
                }
            }

            //Remove rows from data table which are not rented
            foreach (DataRow row in dt_items.Select("QuantityRented = 0"))
            {
                dt_items.Rows.Remove(row);
            }

            // Bind to DataGridView
            dgv_Bill.DataSource = dt_items;

            //Make all cols except QuantityReturned read-only
            foreach (DataGridViewColumn col in dgv_Bill.Columns)
            {
                col.ReadOnly = col.Name != "QuantityReturned";  // all except this
            }

            dgv_Bill.Refresh();

            //Format number as per culture settings
            NumberFormatter.ApplyToDataGridView(dgv_Bill);
        }

        private void AdjustGridHeight()
        {
            if (dgv_Bill.Rows.Count == 0)
                return;

            int totalHeight = dgv_Bill.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dgv_Bill.Rows)
            {
                if (row.IsNewRow) continue; // skip the blank new row if enabled
                totalHeight += row.Height;
            }

            dgv_Bill.Height = (totalHeight + 8) > dgv_Bill.Height ? dgv_Bill.Height : (totalHeight + 8);  //padding a small buffer
        }

        public void GetLocalizedItems()
        {
            string query = "SELECT ItemId, ItemName, Rent, MinRentDays FROM Items";

            l_items = obj_DBAccess.ExecuteQuery(query, reader => new Items
            {
                ItemId = reader.GetInt32(0),
                ItemName = reader.GetString(1),
                Rent = reader.GetDecimal(2),
                MinRentDays = reader.GetInt32(3)
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Bill_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if we are in the "QuantityReturned" column
            if (dgv_Bill.Columns[e.ColumnIndex].Name == "QuantityReturned")
            {
                // Get the value from the "QuantityRented" cell in the same row
                var quantityRentedValue = dgv_Bill.Rows[e.RowIndex].Cells["QuantityRented"].Value;

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

        private void dgv_Bill_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Only apply numeric restriction to QuantityReturned column
            if (dgv_Bill.CurrentCell.OwningColumn.Name == "QuantityReturned" && e.Control is TextBox tb)
            {
                tb.KeyPress -= QuantityReturned_KeyPress; // prevent double subscription
                tb.KeyPress += QuantityReturned_KeyPress;
            }
        }

        private void QuantityReturned_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (like Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow only digits (no negative or decimal input)
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private decimal ComputeBill()
        {
            decimal totalAmount = 0m;

            foreach (DataGridViewRow row in dgv_Bill.Rows)
            {
                if (row.IsNewRow) continue; // skip new row

                var NoOfDaysvalue = row.Cells["RentalDays"].Value;
                var rentValue = row.Cells["Rent"].Value;
                var QuantityRentedValue = row.Cells["QuantityRented"].Value;

                //Assign values safely
                decimal.TryParse(rentValue?.ToString() ?? "0", out decimal rent);
                int.TryParse(QuantityRentedValue?.ToString() ?? "0", out int QuantityRented);
                int.TryParse(NoOfDaysvalue?.ToString() ?? "1", out int NoOfDays);

                totalAmount += rent * QuantityRented * NoOfDays;
            }

            tb_BillAmount.Text = totalAmount.ToString("C2"); // Currency format

            return totalAmount;
        }

        private void dgv_Bill_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_Bill.Columns[e.ColumnIndex].Name == "QuantityReturned")
            {
                string input = e.FormattedValue?.ToString().Trim() ?? "";

                // Convert Marathi ➜ English BEFORE validation
                input = NumberFormatter.ConvertToEnglishDigits(input);

                // Check if it's a valid integer
                if (!int.TryParse(input, out int value) || value < 0)
                {
                    e.Cancel = true;
                    dgv_Bill.Rows[e.RowIndex].ErrorText = "Please enter a positive integer.";
                    return;
                }

                // Get QuantityRented value for this row
                var rentedValue = dgv_Bill.Rows[e.RowIndex].Cells["QuantityRented"].Value;
                int quantityRented = 0;
                int.TryParse(rentedValue?.ToString() ?? "0", out quantityRented);

                // Enforce QuantityReturned ≤ QuantityRented
                if (value > quantityRented)
                {
                    e.Cancel = true;
                    //dgv_Sale.Rows[e.RowIndex].ErrorText = "Returned quantity cannot exceed rented quantity.";
                    dgv_Bill.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    btn_MultipurposeButton.Enabled = false;
                }
                else
                {
                    //dgv_Sale.Rows[e.RowIndex].ErrorText = string.Empty; // clear error
                    dgv_Bill.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    btn_MultipurposeButton.Enabled = true;
                }
            }
        }

        private void dgv_Bill_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgv_Bill.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btn_MultipurposeButton_Click(object sender, EventArgs e)
        {
            if (!BillPaid)
            {
                int total = 0;

                //Logic to find if there are any returned items, if no then close the bill form
                foreach (DataGridViewRow row in dgv_Bill.Rows)
                {
                    // Skip the new row placeholder
                    if (row.IsNewRow) continue;

                    // Assuming the column you want to sum is named "Amount"
                    total += Convert.ToInt32(row.Cells["QuantityReturned"].Value);
                }

                if (total == 0)
                {
                    MessageBox.Show(LangManager.GetString("NoItemsReturned"), LangManager.GetString("NoBill"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //Some or all items returned
                    dt_NewBillItems.Columns.Add("ItemId", typeof(int));
                    dt_NewBillItems.Columns.Add("Rent", typeof(decimal));
                    dt_NewBillItems.Columns.Add("Quantity", typeof(int));

                    //Get total amount for returned items
                    decimal totalAmount = ComputeBill();

                    foreach (DataGridViewRow row in dgv_Bill.Rows)
                    {
                        // Get cell values safely
                        int RentedQty = Convert.ToInt16(row.Cells["QuantityRented"].Value);

                        if (RentedQty > 0)
                        {
                            int ReturnedQty = Convert.ToInt16(row.Cells["QuantityReturned"].Value);

                            if (RentedQty == ReturnedQty)
                            {
                                //All quantity returned
                                UpdateBill(totalAmount, Convert.ToInt32(row.Cells["ItemId"].Value), RentedQty);
                            }
                            else
                            {
                                DataRow newRow = dt_NewBillItems.NewRow();
                                newRow["ItemId"] = row.Cells["ItemId"].Value;
                                newRow["Rent"] = row.Cells["Rent"].Value;
                                newRow["Quantity"] = RentedQty - ReturnedQty;

                                // Add the new row to the DataTable
                                dt_NewBillItems.Rows.Add(newRow);

                                UpdateBill(totalAmount, Convert.ToInt32(row.Cells["ItemId"].Value), RentedQty);
                            }
                        }
                    }

                    if (dt_NewBillItems.Rows.Count > 0)
                    {
                        MessageBox.Show(LangManager.GetString("NewBillCreated"), LangManager.GetString("PartialBill"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CreateNewBill();
                    }
                    else
                    {
                        MessageBox.Show(LangManager.GetString("AllItemsReturned."), LangManager.GetString("BillFinished"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (BillPaid)
            {
                //Remove unbought items from list
                billItems.RemoveAll(bi => bi.Quantity == 0);

                //Compute rental days and total
                foreach (DataRow itemRow in dt_items.Rows.Cast<DataRow>())
                {
                    int itemId = Convert.ToInt32(itemRow["ItemId"]);

                    // Find this item in billItems list
                    var match = billItems.FirstOrDefault(bi => bi.ItemId == itemId);

                    if (match != null)
                    {
                        // If found, update quantity and amount
                        match.ItemName = itemRow["LocalizedName"].ToString();
                        match.RentalDays = Convert.ToInt32(itemRow["RentalDays"]);
                        match.Total = match.Rent * match.Quantity * match.RentalDays;
                    }
                    else
                    {
                        // If item not part of this bill, reset to zero
                        match.RentalDays = 0;
                        match.Total = match.Rent * match.Quantity * match.RentalDays;
                    }
                }

                //Create bill pdf
                BillSaver BillDocument = new BillSaver(BillInformation[0], billItems);

                string fileName = Properties.Settings.Default.SaveDirectory + "\\" + BillID.ToString() + ".pdf";
                BillDocument.GeneratePdf(fileName);
            }

            this.Close();
        }

        private void UpdateBill(decimal totalAmount, int ItemID, int Quantity)
        {
            DateTime RentalEndDate = dtp_EndRentDate.Value.Date;
            DateTime PaymentDate = DateTime.Now.Date;

            //Update Bills table
            string UpdateBillsQuery = @" 
                 UPDATE Bills
            SET 
                RentalEndDate = @RentalEndDate,
                PaymentDate = @PaymentDate,
                TotalAmount = @TotalAmount
            WHERE BillId = @BillId";

            var parameters = new Dictionary<string, object>
            {
                ["@RentalEndDate"] = RentalEndDate,
                ["@PaymentDate"] = PaymentDate,
                ["@TotalAmount"] = totalAmount,
                ["@BillId"] = BillID
            };

            int rowsAffected = obj_DBAccess.ExecuteNonQuery(UpdateBillsQuery, parameters);

            // Update BillItems table
            string UpdateBillItemsQuery = @"
                UPDATE BillItems
                SET 
                    Quantity = @Quantity
                WHERE 
                    ItemID  = @ItemID AND 
                    BillId = @BillId";

            //Reusing parameters dictionary
            parameters.Clear();
            parameters["@Quantity"] = Quantity;
            parameters["@ItemID"] = ItemID;
            parameters["@BillId"] = BillID;

            int itemRowsAffected = obj_DBAccess.ExecuteNonQuery(UpdateBillItemsQuery, parameters);
        }

        private void CreateNewBill()
        {
            long CustomerId = BillInformation[0].CustomerId;
            int AdminId = HardwareRentalApp.UserControls.Login.AdminId;
            DateTime RentalStart = dtp_EndRentDate.Value;
            DateTime? RentalEnd = null;
            string projectOwner = tb_OwnerName.Text.Trim();
            string reference = tb_Reference.Text.Trim();
            string workLocation = tb_WorkLocation.Text.Trim();
            DateTime? paymentDate = null;
            decimal totalAmount = 0;

            // 1. Insert Bill and get BillId
            var billCmd = new SqlCommand(@"
                            INSERT INTO Bills (
                                CustomerId, AdminId, BillDate, RentalStartDate, RentalEndDate,
                                ProjectOwner, Reference, WorkLocation,
                                PaymentDate, TotalAmount
                            )
                            OUTPUT INSERTED.BillId
                            VALUES (
                                @CustomerId, @AdminId, GETDATE(), @RentalStartDate, @RentalEndDate,
                                @ProjectOwner, @Reference, @WorkLocation,
                                @PaymentDate, @TotalAmount
                            )");

            billCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
            billCmd.Parameters.AddWithValue("@AdminId", AdminId);
            billCmd.Parameters.AddWithValue("@RentalStartDate", RentalStart);
            billCmd.Parameters.AddWithValue("@RentalEndDate", (object?)RentalEnd ?? DBNull.Value);
            billCmd.Parameters.AddWithValue("@ProjectOwner", projectOwner);
            billCmd.Parameters.AddWithValue("@Reference", reference);
            billCmd.Parameters.AddWithValue("@WorkLocation", string.IsNullOrWhiteSpace(workLocation) ? DBNull.Value : (object)workLocation);
            billCmd.Parameters.AddWithValue("@PaymentDate", (object?)paymentDate ?? DBNull.Value);
            billCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

            int billId = Convert.ToInt32(obj_DBAccess.ExecuteScalarQuery(billCmd));

            // 2. Insert Bill Items
            foreach (DataRow row in dt_NewBillItems.Rows)
            {
                var itemCmd = new SqlCommand(@"
                INSERT INTO BillItems (BillId, ItemId, Quantity, Rent)
                VALUES (@BillId, @ItemId, @Quantity, @Rent)");

                itemCmd.Parameters.AddWithValue("@BillId", billId);
                itemCmd.Parameters.AddWithValue("@ItemId", row["ItemId"]);
                itemCmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                itemCmd.Parameters.AddWithValue("@Rent", row["Rent"]);

                obj_DBAccess.ExecuteQuery(itemCmd);
            }
        }

        private void dtp_EndRentDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime.TryParse(tb_StartRentDate.Text, out DateTime startDate);

            int rentalDays = (dtp_EndRentDate.Value.Date - startDate).Days + 1; //Added +1 to count same day rent

            foreach (DataRow row in dt_items.Rows)
            {
                int itemId = Convert.ToInt32(row["ItemId"]);

                // Find corresponding item in l_items by ItemId
                var matchingItem = l_items.FirstOrDefault(x => x.ItemId == itemId);

                //if (matchingItem != null)
                {
                    // Apply minimum rent days logic
                    int updatedRentalDays = Math.Max(rentalDays, matchingItem.MinRentDays);
                    row["RentalDays"] = updatedRentalDays;
                }
            }

            ComputeBill();
        }
    }
}
