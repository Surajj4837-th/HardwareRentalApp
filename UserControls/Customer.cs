using System.Data;
using System.Data.SqlClient;
using System.Resources;
using HardwareRentalApp.Classes;
using HardwareRentalApp.Forms;
using static HardwareRentalApp.Classes.Program;

namespace HardwareRentalApp.UserControls
{
    public partial class Customers : UserControl
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Customers).Assembly);
        private DataTable dt_Bills = new DataTable();
        private DataTable dt_InvoiceIDs = new DataTable();
        private DataTable dt_Customers = new DataTable();
        private BindingSource bindingSourceCustomers = new BindingSource();     //Necessary for filtering of data
        private DBInterface obj_DBAccess = new DBInterface();
        private CustomerInfo customer = new CustomerInfo();

        private enum tableName
        {
            Customer,
            Bill
        }

        private enum Bill_Table_Columns
        {
            Sr_No,
            InvoiceID,
            Date,
            Time,
            AdminID,
            BillAmount,
            Paid_Amount,
            View_Bill
        }

        private tableName currentTable;

        public Customers()
        {
            InitializeComponent();

            currentTable = tableName.Customer;

            DisableButtons();

            ResetDGV();

            loadData();

            ArrangeDGVButtons();

            createTable();

            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            this.lbl_mainPanel.Text = LangManager.GetString("CustomerInformation");
            this.lbl_search.Text = LangManager.GetString("Search");
            this.btn_AddCustomer.Text = LangManager.GetString("AddNewCustomer");
            this.btn_ShowBills.Text = LangManager.GetString("ShowBills");
        }

        private void ResetDGV()
        {
            dgv_MultipurposeTable.DataSource = null;
            dgv_MultipurposeTable.Rows.Clear();
            dgv_MultipurposeTable.Columns.Clear();
        }

        private void createTable()
        {
            if (currentTable == tableName.Customer)
            {
                // Rename the column headers after attaching the data table only
                dgv_MultipurposeTable.Columns["CustomerID"].HeaderText = LangManager.GetString("CustomerID");
                dgv_MultipurposeTable.Columns["LesseeName"].HeaderText = LangManager.GetString("LesseeName");
                dgv_MultipurposeTable.Columns["LesseeAddress"].HeaderText = LangManager.GetString("LesseeAddress");
                dgv_MultipurposeTable.Columns["MobileNumber"].HeaderText = LangManager.GetString("MobileNumber");
                lbl_mainPanel.Text = LangManager.GetString("CustomerInformation");
            }
            else if (currentTable == tableName.Bill)
            {
                dgv_MultipurposeTable.Columns["BillId"].HeaderText = LangManager.GetString("InvoiceID");

                dgv_MultipurposeTable.Columns["BillDate"].HeaderText = LangManager.GetString("BillDate");

                dgv_MultipurposeTable.Columns["RentalStartDate"].HeaderText = LangManager.GetString("RentalStartDate");

                dgv_MultipurposeTable.Columns["WorkLocation"].HeaderText = LangManager.GetString("WorkLocation");

                dgv_MultipurposeTable.Columns["IsPaid"].HeaderText = LangManager.GetString("Paid"); ;

                lbl_mainPanel.Text = LangManager.GetString("BillInformation");
            }
        }

        private void DisableButtons()
        {
            btn_ShowBills.Enabled = false;
        }

        private void EnableButtons()
        {
            btn_ShowBills.Enabled = true;
        }

        private void loadData()
        {
            if (currentTable == tableName.Customer)
            {
                string SelectQuery = "Select * from Customers";

                dt_Customers.Rows.Clear();

                obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_Customers, null);

                // Bind DataTable to BindingSource
                bindingSourceCustomers.DataSource = dt_Customers;

                // Bind BindingSource to DataGridView
                dgv_MultipurposeTable.DataSource = bindingSourceCustomers;
            }
            else if (currentTable == tableName.Bill)
            {
                //List<int> UnbilledBills = new List<int>();

                ////Get invoice IDs from database
                //string SelectQuery = "Select DISTINCT InvoiceNo FROM [" + customer.CustomerID + "];";

                //dt_InvoiceIDs.Columns.Add("InvoiceNo");

                //dt_InvoiceIDs.Rows.Clear();

                //obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_InvoiceIDs, null);

                //// Get more details of each invoice
                //// Fill the table with the details
                //int SrNo = 1;

                //foreach (DataRow row in dt_InvoiceIDs.Rows)
                //{
                //    string invoiceID = row.ItemArray[0].ToString();

                //    DataRow dr_newRow = dt_Bills.NewRow();

                //    SelectQuery = "Select * from [" + customer.CustomerID + "] where InvoiceNo = @invoiceID;";

                //    DataTable dt_Purchases = new DataTable();

                //    var parameters = new Dictionary<string, object> { { "@invoiceID", invoiceID } };

                //    obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_Purchases, parameters);

                //    string Date = dt_Purchases.Rows[0]["Date"].ToString();
                //    string time = dt_Purchases.Rows[0]["Time"].ToString();
                //    string AdminID = dt_Purchases.Rows[0]["AdminID"].ToString();

                //    // If invoice is for advance payment
                //    if (dt_Purchases.Rows.Count == 1)
                //    {
                //        // Get advance amount
                //        DataTable dt_advance = new DataTable();

                //        SelectQuery = "Select amount from [" + customer.CustomerID + "] where InvoiceNo = @invoiceID and BillCategory = 'advance';";

                //        parameters = new Dictionary<string, object> { { "@invoiceID", invoiceID } };

                //        obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_advance, parameters);

                //        decimal advance_amount = Convert.ToDecimal(dt_advance.Rows[0][0]);

                //        // Fill row
                //        dr_newRow[0] = SrNo.ToString();
                //        dr_newRow[1] = invoiceID.ToString();
                //        dr_newRow[2] = Date.ToString();
                //        dr_newRow[3] = time.ToString();
                //        dr_newRow[4] = AdminID.ToString();
                //        dr_newRow[5] = "";
                //        dr_newRow[6] = advance_amount.ToString();
                //    }
                //    else
                //    {
                //        //Get bill amount
                //        DataTable dt_amount = new DataTable();

                //        SelectQuery = "Select SUM(Amount) FROM [" + customer.CustomerID + "] WHERE InvoiceNo = @invoiceID and BillCategory = 'Sale';";

                //        parameters = new Dictionary<string, object> { { "@invoiceID", invoiceID } };

                //        obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_amount, parameters);

                //        decimal bill_amount = Convert.ToDecimal(dt_amount.Rows[0][0]);

                //        //Get shipping
                //        DataTable dt_shipping = new DataTable();

                //        SelectQuery = "Select amount from [" + customer.CustomerID + "] where InvoiceNo = @invoiceID and BillCategory = 'shipping';";

                //        parameters = new Dictionary<string, object> { { "@invoiceID", invoiceID } };

                //        obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_shipping, parameters);

                //        decimal shipping_amount = 0.0M;

                //        foreach (DataRow shippingRow in dt_shipping.Rows)
                //            shipping_amount += Convert.ToDecimal(shippingRow[0]);

                //        // Get discount
                //        DataTable dt_discount = new DataTable();
                //        SelectQuery = "select amount from [" + customer.CustomerID + "] where InvoiceNo = @invoiceID and BillCategory = 'discount';";

                //        parameters = new Dictionary<string, object> { { "@invoiceID", invoiceID } };

                //        obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_discount, parameters);

                //        decimal discount_amount = 0.0M;

                //        foreach (DataRow discountRow in dt_discount.Rows)
                //            discount_amount += Convert.ToDecimal(discountRow[0]);

                //        // Get paid amount
                //        DataTable dt_payment = new DataTable();
                //        SelectQuery = "Select amount from [" + customer.CustomerID + "] where InvoiceNo = @invoiceID and BillCategory = 'payment';";

                //        parameters = new Dictionary<string, object> { { "@invoiceID", invoiceID } };

                //        obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_payment, parameters);

                //        decimal paid_amount = 0.0M;

                //        foreach (DataRow paymentRow in dt_payment.Rows)
                //            paid_amount += Convert.ToDecimal(paymentRow[0]);

                //        decimal totalBill = (bill_amount + shipping_amount - discount_amount);

                //        // Fill row
                //        dr_newRow[0] = SrNo.ToString();
                //        dr_newRow[1] = invoiceID.ToString();
                //        dr_newRow[2] = Date.ToString();
                //        dr_newRow[3] = time.ToString();
                //        dr_newRow[4] = AdminID.ToString();
                //        dr_newRow[5] = totalBill.ToString();
                //        dr_newRow[6] = paid_amount.ToString();

                //        //Highlight unsettled bill
                //        if (totalBill > Convert.ToDecimal(paid_amount))
                //        {
                //            UnbilledBills.Add(SrNo - 1);
                //        }
                //    }

                //    // Add new row to table
                //    dt_Bills.Rows.Add(dr_newRow);

                //    SrNo++;
                //}

                //for (int i = 0; i < UnbilledBills.Count; i++)
                //{
                //    dgv_MultipurposeTable.Rows[UnbilledBills[i]].DefaultCellStyle.BackColor = Color.OrangeRed;
                //}

                //dgv_MultipurposeTable.Update();
                //dgv_MultipurposeTable.Refresh();
            }
        }

        private void ArrangeDGVButtons()
        {
            dgv_MultipurposeTable.EnableHeadersVisualStyles = false; // Required to allow custom styling

            if (currentTable == tableName.Bill)
            {
                DataGridViewButtonColumn Select_bill_col = new DataGridViewButtonColumn();

                Select_bill_col.Name = "Select_bill_column";
                Select_bill_col.Text = "Show Bill";

                if (dgv_MultipurposeTable.Columns["Select_bill_column"] == null)
                {
                    dgv_MultipurposeTable.Columns.Insert(5, Select_bill_col);
                    dgv_MultipurposeTable.Columns[5].HeaderText = LangManager.GetString("ShowBill");
                    //dgv_MultipurposeTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else if (GlobalState.e_LoginProfile == Profile.Owner && currentTable == tableName.Customer)
            {
                //Add buttons
                //if (!dgv_MultipurposeTable.Columns.Contains("ShowBill"))
                //{
                //    DataGridViewButtonColumn ModifyBtnColumn = new DataGridViewButtonColumn();
                //    ModifyBtnColumn.Name = "ShowBill";                                                 // Logical name
                //    ModifyBtnColumn.HeaderText = LangManager.GetString("ShowBill");             // Column header
                //    ModifyBtnColumn.UseColumnTextForButtonValue = true;
                //    ModifyBtnColumn.HeaderCell.Style.BackColor = Color.Yellow;

                //    dgv_MultipurposeTable.Columns.Add(ModifyBtnColumn);
                //}
            }
            else if (GlobalState.e_LoginProfile == Profile.Employee)       //Already default hidden
            {
                //disable buttons
            }

            dgv_MultipurposeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            //Remove the dgv row selection
            dgv_MultipurposeTable.ClearSelection(); // Remove all selections

            using (var AC_form = new AddCustomer())
            {
                if (AC_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    loadData();
                }
            }
        }

        private void dgv_MultipurposeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            string columnName = dgv_MultipurposeTable.Columns[e.ColumnIndex].Name;

            if (currentTable == tableName.Customer)
            {
                if (row_index >= 0) // Ensure it's not header
                {
                    dgv_MultipurposeTable.ClearSelection(); // Clear any previous selection
                    dgv_MultipurposeTable.Rows[row_index].Selected = true; // Select the clicked row

                    customer.CustomerID = dgv_MultipurposeTable.Rows[row_index].Cells["CustomerID"].Value.ToString();
                    customer.LesseeName = dgv_MultipurposeTable.Rows[row_index].Cells["LesseeName"].Value.ToString();
                    customer.LesseeAddress = dgv_MultipurposeTable.Rows[row_index].Cells["LesseeAddress"].Value.ToString();
                    customer.MobileNum = dgv_MultipurposeTable.Rows[row_index].Cells["MobileNumber"].Value.ToString();

                    EnableButtons();
                }
                else
                {
                    dgv_MultipurposeTable.ClearSelection();
                    DisableButtons();
                    return;
                }
            }

            //if (columnName == "Modify_Customer" && currentTable == tableName.Customer)
            //{
            //    //Get values from modify form

            //    customer.CustomerID = dgv_MultipurposeTable.Rows[row_index].Cells["ID"].Value.ToString();
            //    customer.FirstName = dgv_MultipurposeTable.Rows[row_index].Cells["FirstName"].Value.ToString();
            //    customer.Surname = dgv_MultipurposeTable.Rows[row_index].Cells["Surname"].Value.ToString();
            //    customer.MobileNum = dgv_MultipurposeTable.Rows[row_index].Cells["MobileNo"].Value.ToString();
            //    customer.Village = dgv_MultipurposeTable.Rows[row_index].Cells["Village"].Value.ToString();
            //    customer.District = dgv_MultipurposeTable.Rows[row_index].Cells["District"].Value.ToString();
            //    customer.Pincode = dgv_MultipurposeTable.Rows[row_index].Cells["Pincode"].Value.ToString();

            //    using (var MP_form = new ModifyCustomer(customer))
            //    {
            //        if (MP_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        {
            //            this.loadData();
            //        }
            //    }
            //}
            //else if (columnName == "Delete_Customer" && currentTable == tableName.Customer)
            //{
            //    DialogResult DeleteConfirmation = MessageBox.Show(LangManager.GetString("DeleteCustomer"), LangManager.GetString("ConfirmDelete"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    if (DeleteConfirmation == DialogResult.Yes)
            //    {
            //        string MobileNo = dgv_MultipurposeTable.Rows[row_index].Cells["MobileNo"].Value.ToString();

            //        SqlCommand deleteCommand = new SqlCommand("DELETE FROM customer WHERE MobileNo = @MobileNo");
            //        deleteCommand.Parameters.AddWithValue("@MobileNo", MobileNo);

            //        int row = obj_DBAccess.ExecuteQuery(deleteCommand);

            //        loadData();
            //    }
            //}
            /*else*/
            if (columnName == "Select_bill_column" && currentTable == tableName.Bill)
            {
                //if (dgv_MultipurposeTable.Columns["Select_bill_column"] != null && e.ColumnIndex == dgv_MultipurposeTable.Columns["Select_bill_column"].Index)
                //{
                //    string invoiceID = dt_Bills.Rows[row_index]["InvoiceNo"].ToString();
                //    Form f_Bill = new Bill(customer.CustomerID, invoiceID);
                //    f_Bill.ShowDialog();
                //}
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (currentTable == tableName.Customer)
                bindingSourceCustomers.Filter = "Lessee like '%" + tb_search.Text + "%'";
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection();

            foreach (DataGridViewColumn col in dgv_MultipurposeTable.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DisableButtons();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection(); // Remove all selections
            DisableButtons();
        }

        private void pnl_customerTable_Click(object sender, EventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection(); // Remove all selections
            DisableButtons();
        }

        private void dgv_MultipurposeTable_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgv_MultipurposeTable.HitTest(e.X, e.Y);

            // If user clicked on empty area (not on a cell or header)
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgv_MultipurposeTable.ClearSelection();
                DisableButtons();
            }
        }

        private void tb_search_MouseClick(object sender, MouseEventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection(); // Remove all selections
            DisableButtons();
        }

        private void lbl_search_Click(object sender, EventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection(); // Remove all selections
            DisableButtons();
        }

        private void lbl_mainPanel_Click(object sender, EventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection(); // Remove all selections
            DisableButtons();
        }

        private void btn_ShowBills_Click(object sender, EventArgs e)
        {
            ////Remove the dgv row selection
            //dgv_MultipurposeTable.ClearSelection(); // Remove all selections

            ////Check if the table exists in database
            //DataTable dt_table = new DataTable();
            //string SelectQuery = "Select 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = '" + customer.CustomerID + "'";

            //dt_table.Rows.Clear();

            //obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_table, null);

            //if (dt_table.Rows.Count == 1)
            //{
            //    // Clear controls on form
            //    EnableDisableBillControls();

            //    lbl_mainPanel.Text = LangManager.GetString("BillInformation");

            //    currentTable = tableName.Bill;

            //    dgv_MultipurposeTable.DataSource = dt_Bills;

            //    // Create bill table
            //    createTable();

            //    // Load bill related data on DGV
            //    loadData();

            //    // Add bill related buttons
            //    ArrangeDGVButtons();
            //}
            //else
            //{
            //    MessageBox.Show(LangManager.GetString("NoSalesByCustomer"));
            //}
        }
        private void EnableDisableBillControls()
        {
            dgv_MultipurposeTable.DataSource = null;
            dgv_MultipurposeTable.Rows.Clear();
            dgv_MultipurposeTable.Columns.Clear();

            DisableButtons();
            btn_AddCustomer.Enabled = false;

            lbl_search.Hide();
            tb_search.Hide();
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            using (Sale AC_form = new Sale(customer))
            {
                if (AC_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }
    }
}
