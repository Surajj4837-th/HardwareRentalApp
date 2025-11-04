using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareRentalApp.Forms
{
    public partial class UpdateRent : Form
    {
        private int ItemID;
        private string ItemName;
        //private decimal RentPerDay;
        public decimal RentPerDay { get; private set; }

        public UpdateRent(int ItemID, string ItemName, decimal RentPerDay)
        {
            InitializeComponent();
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.RentPerDay = RentPerDay;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateRent_Load(object sender, EventArgs e)
        {
            tb_ItemID.Text = ItemID.ToString();
            tb_ItemName.Text = ItemName;
            tb_RentPerDay.Text = RentPerDay.ToString("F2");
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_RentPerDay.Text))
            {
                MessageBox.Show("Please enter a rent amount before saving.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_RentPerDay.Focus();
                return; // Stop execution here
            }
            else
            {
                this.RentPerDay = Convert.ToDecimal(tb_RentPerDay.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
