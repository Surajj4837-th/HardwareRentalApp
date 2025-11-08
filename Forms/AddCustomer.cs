using HardwareRentalApp.Classes;
using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HardwareRentalApp.Forms
{
    public partial class AddCustomer : Form
    {
        private DBInterface obj_DBAccess = new DBInterface();
        ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(AddCustomer).Assembly);
        public AddCustomer()
        {
            InitializeComponent();

            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            this.btn_Add.Text = LangManager.GetString("Save");
            this.lbl_main.Text = LangManager.GetString("AddNewCustomer");
            this.lbl_LesseeAddress.Text = LangManager.GetString("LesseeAddress");
            this.lbl_MobileNum.Text = LangManager.GetString("MobileNumber");
            this.lbl_LesseeName.Text = LangManager.GetString("LesseeName");
        }
        private bool IsNewCustomer(string MobileNo)
        {
            bool IsNewCustomer = true;
            DataTable dt_temp = new DataTable();

            string checkQuery = "Select * from Customers where MobileNumber = @MobileNo";

            var parameters = new Dictionary<string, object> { { "@MobileNo", MobileNo } };

            obj_DBAccess.ReadDataThroughAdapter(checkQuery, dt_temp, parameters);

            if (dt_temp.Rows.Count > 0)
            {
                IsNewCustomer = false;
            }
            else
            {
                IsNewCustomer = true;
            }

            return IsNewCustomer;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string LesseeName = tb_LesseeName.Text;
            string MobileNo = tb_MobileNum.Text;
            string LesseeAddress = tb_LesseeAddress.Text;

            if (LesseeName.Equals(""))
            {
                MessageBox.Show(LangManager.GetString("EnterName"));
                tb_LesseeName.Focus();
            }
            else if (MobileNo.Equals(""))
            {
                MessageBox.Show(LangManager.GetString("EnterCustomerMobileNumber"));
                tb_MobileNum.Focus();
            }
            else if (tb_MobileNum.Text.Length != 10)
            {
                MessageBox.Show(LangManager.GetString("EnterValidMobileNumber"));
                tb_MobileNum.Focus();
            }
            else
            {
                if (IsNewCustomer(MobileNo))
                {
                    SqlCommand insertCommand = new SqlCommand("insert into Customers(LesseeName, LesseeAddress, MobileNumber) values(@LesseeName, @LesseeAddress, @MobileNo)");
                    insertCommand.Parameters.AddWithValue("@LesseeName", LesseeName);
                    insertCommand.Parameters.AddWithValue("@LesseeAddress", LesseeAddress);
                    insertCommand.Parameters.AddWithValue("@MobileNo", Convert.ToInt64(MobileNo));

                    int row = obj_DBAccess.ExecuteQuery(insertCommand);

                    if (row == 1)
                    {
                        MessageBox.Show(LangManager.GetString("NewCustomerAdded"));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(LangManager.GetString("ErrorOcurred"));
                    }
                }
                else
                {
                    MessageBox.Show(LangManager.GetString("CustomerExists"));
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_MobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Allow control keys (e.g., backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow only digits
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limit to 10 digits
            if (textBox.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void tb_Pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Allow control keys like backspace
            if (char.IsControl(e.KeyChar))
                return;

            // Allow only digits (0-9)
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Prevent more than 6 digits
            if (textBox.Text.Length >= 6)
            {
                e.Handled = true;
            }
        }
    }
}
