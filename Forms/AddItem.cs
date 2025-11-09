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
    public partial class AddItem : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(AddItem).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            lbl_main.Text = LangManager.GetString("AddNewItem");
            lbl_ItemName.Text = LangManager.GetString("ItemName");
            lbl_Rent.Text = LangManager.GetString("Rent");
            lbl_MinRentalDays.Text = LangManager.GetString("MinRentalDays");
            btn_Add.Text = LangManager.GetString("Add");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ItemName.Text))
            {
                MessageBox.Show("Please enter an item name before saving.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ItemName.Focus();
                return; // Stop execution here
            }
            else if (string.IsNullOrWhiteSpace(tb_RentPerDay.Text))
            {
                MessageBox.Show("Please enter a rent amount before saving.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_RentPerDay.Focus();
                return; // Stop execution here
            }
            else if (string.IsNullOrWhiteSpace(tb_MinRentalDays.Text))
            {
                MessageBox.Show("Please enter a min rental days before saving.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_MinRentalDays.Focus();
                return; // Stop execution here
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Do you want to save the data?",
                    "Confirm Save",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string query = "INSERT INTO Items (ItemName, Rent, MinRentDays) VALUES (@ItemName, @Rent, @MinRentDays)";

                    var parameters = new Dictionary<string, object>
                    {
                        { "@ItemName", tb_ItemName.Text },
                        { "@Rent", Convert.ToDecimal(tb_RentPerDay.Text) },
                        { "@MinRentDays", Convert.ToInt32(tb_MinRentalDays.Text) }
                    };

                    int rows = obj_DBAccess.ExecuteNonQuery(query, parameters);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void tb_RentPerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Allow control keys like Backspace
            if (char.IsControl(e.KeyChar))
                return;

            // Allow only one decimal point
            if (e.KeyChar == '.' && tb.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Allow digits and dot only
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tb_MinRentalDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Allow control keys like Backspace
            if (char.IsControl(e.KeyChar))
                return;

            // Allow only one decimal point
            if (e.KeyChar == '.' && tb.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Allow digits and dot only
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
