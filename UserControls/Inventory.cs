using HardwareRentalApp.Classes;
using HardwareRentalApp.Forms;
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

namespace HardwareRentalApp.UserControls
{
    public partial class Inventory : UserControl
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Inventory).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();
        private BindingSource bindingSourceCustomers = new BindingSource();
        private DataTable dt_Items = new DataTable();
        private int ItemID = -1;
        private string ItemName = "";
        private decimal RentPerDay = 0.0M;

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            loadData();

            ArrangeDGVButtons();
        }

        private void ArrangeDGVButtons()
        {
            dgv_InventoryTable.EnableHeadersVisualStyles = false; // Required to allow custom styling
            DataGridViewButtonColumn Select_bill_col = new DataGridViewButtonColumn();

            Select_bill_col.Name = "Select_item_column";
            Select_bill_col.Text = "Update Rent";

            if (dgv_InventoryTable.Columns["Select_item_column"] == null)
            {
                Select_bill_col.UseColumnTextForButtonValue = true;
                int insertIndex = dgv_InventoryTable.Columns.Count;
                dgv_InventoryTable.Columns.Insert(insertIndex, Select_bill_col);

                dgv_InventoryTable.Columns[insertIndex].HeaderText = LangManager.GetString("UpdateRent");
            }

        }

        private void loadData()
        {
            string SelectQuery = "Select * from Items";

            dt_Items.Rows.Clear();

            obj_DBAccess.ReadDataThroughAdapter(SelectQuery, dt_Items, null);

            // Bind DataTable to BindingSource
            bindingSourceCustomers.DataSource = dt_Items;

            // Bind BindingSource to DataGridView
            dgv_InventoryTable.DataSource = bindingSourceCustomers;
        }

        private void UpdateRent(int itemID, decimal newRent)
        {
            string UpdateQuery = "UPDATE Items SET Rent = @Rent WHERE ItemID = @ItemID";
            var parameters = new Dictionary<string, object>
            {
                { "@Rent", newRent },
                { "@ItemID", itemID }
            };
            object value = obj_DBAccess.ExecuteNonQuery(UpdateQuery, parameters);
        }

        private void dgv_InventoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on the column header or outside valid rows
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            int row_index = e.RowIndex;

            ItemID = Convert.ToInt32(dgv_InventoryTable.Rows[row_index].Cells["ItemID"].Value);
            ItemName = dgv_InventoryTable.Rows[row_index].Cells["ItemName"].Value.ToString();
            RentPerDay = Convert.ToDecimal(dgv_InventoryTable.Rows[row_index].Cells["Rent"].Value);

            using (var UR_form = new UpdateRent(ItemID, ItemName, RentPerDay))
            {
                if (UR_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // ✅ Get the new rent value
                    decimal updatedRent = UR_form.RentPerDay;

                    UpdateRent(ItemID, updatedRent);

                    loadData();
                }
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            bindingSourceCustomers.Filter = "ItemName like '%" + tb_search.Text + "%'";
        }
    }
}
