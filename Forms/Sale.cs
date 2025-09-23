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
    public partial class Sale : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Sale).Assembly);
        private DBInterface obj_DBAccess = new DBInterface();

        public Sale()
        {
            InitializeComponent();
        }

        public List<Items> GetLocalizedItems()
        {
            string query = "SELECT ItemId, ItemKey, Price FROM Items";

            var items = obj_DBAccess.ExecuteQuery(query, reader => new Items
            {
                ItemId = reader.GetInt32(0),
                ItemKey = reader.GetString(1),
                Price = reader.GetDecimal(2)
            });

            LocalizeItems(items);
            return items;
        }

        private void LocalizeItems(List<Items> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                string localizedName = LangManager.GetString(
                    items[i].ItemKey,
                    Thread.CurrentThread.CurrentUICulture
                );

                var item = items[i];
                item.LocalizedName = string.IsNullOrEmpty(localizedName)
                                        ? item.ItemKey
                                        : localizedName;
                items[i] = item;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
