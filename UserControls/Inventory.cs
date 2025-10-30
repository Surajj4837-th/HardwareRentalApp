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

namespace HardwareRentalApp.UserControls
{
    public partial class Inventory : UserControl
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Inventory).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();
        private BindingSource bindingSourceCustomers = new BindingSource();
        private DataTable dt_Items = new DataTable();
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
    }
}
