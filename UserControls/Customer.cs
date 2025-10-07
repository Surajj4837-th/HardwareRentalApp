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

                lbl_mainPanel.Text = LangManager.GetString("BillInformation");
            }
        }

        private void DisableButtons()
        {
            btn_ShowBills.Enabled = false;
            btn_Sale.Enabled = false;
        }

        private void EnableButtons()
        {
            btn_ShowBills.Enabled = true;
            btn_Sale.Enabled = true;
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
                string query = @"
                SELECT 
                    BillId,
                    BillDate,
                    RentalStartDate,
                    WorkLocation
                FROM Bills
                WHERE CustomerId = @CustomerId
                ORDER BY BillDate DESC";

                DataTable dt = new DataTable();

                // Prepare parameters
                var parameters = new Dictionary<string, object>
                    {
                        { "@CustomerId", customer.CustomerID }
                    };

                // Call your DB method
                obj_DBAccess.ReadDataThroughAdapter(query, dt, parameters);

                // Bind to DataGridView
                dgv_MultipurposeTable.DataSource = dt;
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
                    Select_bill_col.UseColumnTextForButtonValue = true;
                    int insertIndex = Math.Min(5, dgv_MultipurposeTable.Columns.Count);
                    dgv_MultipurposeTable.Columns.Insert(insertIndex, Select_bill_col);

                    dgv_MultipurposeTable.Columns[insertIndex].HeaderText = LangManager.GetString("ShowBill");
                }
            }
            else if (GlobalState.e_LoginProfile == Profile.Owner && currentTable == tableName.Customer)
            {

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

                    customer.CustomerID = Convert.ToInt64(dgv_MultipurposeTable.Rows[row_index].Cells["CustomerID"].Value);
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
                if (dgv_MultipurposeTable.Columns["Select_bill_column"] != null && e.ColumnIndex == dgv_MultipurposeTable.Columns["Select_bill_column"].Index)
                {
                    int invoiceID = Convert.ToInt16(dgv_MultipurposeTable.Rows[row_index].Cells["BillId"]);
                    Form f_Bill = new Bill(invoiceID);
                    f_Bill.ShowDialog();
                }
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (currentTable == tableName.Customer)
                bindingSourceCustomers.Filter = "LesseeName like '%" + tb_search.Text + "%'";
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dgv_MultipurposeTable.ClearSelection();

            foreach (DataGridViewColumn col in dgv_MultipurposeTable.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            currentTable = tableName.Bill;
            ResetDGV();
            loadData();     //What happens if there is no bill for the customer? Else if needed

            //if()
            //{ 
            //}
            //else
            //{
            //    MessageBox.Show(LangManager.GetString("NoSalesByCustomer"));
            //}

            ArrangeDGVButtons();
            dgv_MultipurposeTable.ClearSelection();
            createTable();

            EnableDisableBillControls();
        }
        private void EnableDisableBillControls()
        {
            DisableButtons();

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
