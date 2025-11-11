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
    public partial class UpdateItem : Form
    {
        ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(UpdateItem).Assembly);
        private int ItemID;
        private string ItemName;
        private decimal RentPerDay;
        public int MinRentDays;
        public Items updatedItemDetails;

        public UpdateItem(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            this.ItemID = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);
            this.ItemName = Convert.ToString(selectedRow.Cells["ItemName"].Value);
            this.RentPerDay = Convert.ToDecimal(selectedRow.Cells["Rent"].Value);
            this.MinRentDays = Convert.ToInt32(selectedRow.Cells["MinRentDays"].Value);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateRent_Load(object sender, EventArgs e)
        {
            lbl_main.Text = LangManager.GetString("UpdateItem");
            lbl_ItemID.Text = LangManager.GetString("ItemID");
            lbl_ItemName.Text = LangManager.GetString("ItemName");
            lbl_Rent.Text = LangManager.GetString("Rent");
            lbl_MinRentalDays.Text = LangManager.GetString("MinRentalDays");
            btn_Update.Text = LangManager.GetString("Update");

            tb_ItemID.Text = ItemID.ToString();
            tb_ItemName.Text = ItemName;
            tb_RentPerDay.Text = RentPerDay.ToString("F2");
            tb_MinRentalDays.Text = MinRentDays.ToString();
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
                MessageBox.Show(LangManager.GetString("MissingRent"), LangManager.GetString("MissingInput"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_RentPerDay.Focus();
                return; // Stop execution here
            }
            else if (string.IsNullOrWhiteSpace(tb_MinRentalDays.Text))
            {
                MessageBox.Show(LangManager.GetString("MissingMinRentalDays"), LangManager.GetString("MissingInput"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_MinRentalDays.Focus();
                return; // Stop execution here
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    LangManager.GetString("SaveData"),
                    LangManager.GetString("ConfirmSave"),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    updatedItemDetails.Rent = Convert.ToDecimal(tb_RentPerDay.Text);
                    updatedItemDetails.MinRentDays = Convert.ToInt32(tb_MinRentalDays.Text);
                    updatedItemDetails.ItemId = this.ItemID;
                    updatedItemDetails.ItemName = this.ItemName;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
