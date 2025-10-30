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
