using HardwareRentalApp.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Resources;

namespace HardwareRentalApp.Forms
{
    public partial class ActivateProduct : Form
    {
        private ActivationKeyDecoder Obj_ActivationKeyDecoder = new ActivationKeyDecoder();
        private string ActivationKey = "";
        private string UserID = "";
        private string MACAddress;
        private DataTable dt_ProductActivation = new DataTable();
        private DBInterface obj_DBAccess = new DBInterface();
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(ActivateProduct).Assembly);

        public ActivateProduct()
        {
            InitializeComponent();
        }

        private void ActivateProduct_Load(object sender, EventArgs e)
        {
            ApplyLanguage();

            MACAddress = "Not_Found";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Get the MAC address of Wi-Fi adapter
                if (nic.Name.Equals("Wi-Fi"))
                {
                    // Get the MAC address
                    PhysicalAddress macAddr = nic.GetPhysicalAddress();
                    MACAddress = FormatMacAddress(macAddr);
                }
            }

            tb_MACAddress.Text = MACAddress;

            // Get today's date
            DateTime today = DateTime.Today;

            // Format today's date in ddMMyyyy format
            tb_RequestDate.Text = today.ToString("dd-MM-yyyy");
        }

        public void ApplyLanguage()
        {
            this.btn_Activate.Text = LangManager.GetString("Activation");
            this.lbl_ActivateProduct.Text = LangManager.GetString("ActivateProduct");
            this.lbl_ActivationKey.Text = LangManager.GetString("ActivationKey");
            this.lbl_MACAddress.Text = LangManager.GetString("MACAddress");
            this.lbl_RequestDate.Text = LangManager.GetString("RequestDate");
            this.lbl_UserID.Text = LangManager.GetString("UserID");
        }

        public ActivateProduct(string message)
        {
            InitializeComponent();
            lbl_message.Text = message;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void tb_UserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // If not a digit or control key, suppress the input
            e.Handled = true;
        }

        private DateTime ActivateThisProduct()
        {
            // Activation key format: 32
            // User ID (6), MAC address (12), Product type (1), License type (1), Activation days (4), Request date (8)
            // 0-5,         6-17,               18,                 19,              20 - 23,           24-31

            string UserIDFromKey = ActivationKey.Substring(0, 6);
            string MACAddressFromKey = ActivationKey.Substring(6, 12);
            string ProductTypeFromKey = ActivationKey.Substring(18, 1);
            string LicenseTypeFromKey = ActivationKey.Substring(19, 1);
            Int16 ActivationDaysFromKey = Convert.ToInt16(ActivationKey.Substring(20, 4));
            string RequestDate = ActivationKey.Substring(24, 8);

            // Get today's date
            DateTime today = DateTime.Today;

            // Format today's date in ddMMyyyy format
            string ActivationDate = today.ToString("ddMMyyyy");

            // Add days to today's date
            DateTime ExpiryDate = today.AddDays(Convert.ToInt16(ActivationDaysFromKey));

            SqlCommand insertCommand = new SqlCommand("insert into ProductActivations(ActivationKey, UserID, MACAddress, ProductType, LicenseType, ActivationDays, RequestDate, ActivationDate, ExpiryDate) " +
                                                      "values(@ActivationKey, @UserID, @MACAddress, @ProductType, @LicenseType, @ActivationDays, @RequestDate, @ActivationDate, @ExpiryDate)");

            insertCommand.Parameters.AddWithValue("@ActivationKey", ActivationKey);
            insertCommand.Parameters.AddWithValue("@UserID", UserID);
            insertCommand.Parameters.AddWithValue("@MACAddress", MACAddress);
            insertCommand.Parameters.AddWithValue("@ProductType", ProductTypeFromKey);
            insertCommand.Parameters.AddWithValue("@LicenseType", LicenseTypeFromKey);
            insertCommand.Parameters.AddWithValue("@ActivationDays", ActivationDaysFromKey);
            insertCommand.Parameters.AddWithValue("@ActivationDate", ActivationDate);
            insertCommand.Parameters.AddWithValue("@RequestDate", RequestDate);
            insertCommand.Parameters.AddWithValue("@ExpiryDate", ExpiryDate.ToString("ddMMyyyy"));

            int row = obj_DBAccess.ExecuteQuery(insertCommand);

            return ExpiryDate;
        }

        private bool VerifyUserID()
        {
            bool IsUserCorrect = true;

            string UserIDFromKey = ActivationKey.Substring(0, 6);

            if (UserIDFromKey.Equals(UserID))
            {
                IsUserCorrect = true;
            }
            else
            {
                IsUserCorrect = false;
            }

            return IsUserCorrect;
        }

        private bool VerifyMACAddress()
        {
            bool IsMACAddressValid = false;

            string MACAddressFromKey = ActivationKey.Substring(6, 12);

            if (MACAddressFromKey.Equals(MACAddress))
            {
                IsMACAddressValid = true;
            }
            else
            {
                IsMACAddressValid = false;
            }

            return IsMACAddressValid;
        }

        private bool IsKeyNew()
        {
            bool IsNew = true;

            string query = "Select * from ProductActivations where ActivationKey = @ActivationKey";

            DataTable dt_temp = new DataTable();

            var parameters = new Dictionary<string, object> { { "@ActivationKey", ActivationKey } };

            obj_DBAccess.ReadDataThroughAdapter(query, dt_temp, parameters);

            if (dt_temp.Rows.Count > 0)
            {
                IsNew = false;
            }

            return IsNew;
        }

        private bool IsKeyValid()
        {
            bool IsKeyValid = true;

            int KeyLength = ActivationKey.Length;

            if (KeyLength != 32)
            {
                IsKeyValid = false;
            }

            return IsKeyValid;
        }

        private void btn_Activate_Click(object sender, EventArgs e)
        {
            if (tb_ActivationKey.Text.Equals(""))
            {
                MessageBox.Show(LangManager.GetString("ActivationKeyNeeded"));
            }
            else if (tb_UserID.Text.Equals(""))
            {
                MessageBox.Show(LangManager.GetString("UserIDNotProvided"));
            }
            else
            {
                ActivationKey = Obj_ActivationKeyDecoder.DecodeActivationKey(tb_ActivationKey.Text);
                UserID = tb_UserID.Text.PadLeft(6, '0');

                if (!VerifyUserID())
                {
                    MessageBox.Show(LangManager.GetString("ActivationKeyDoesNotBelongToUser"));
                }
                else if (!VerifyMACAddress())
                {
                    MessageBox.Show(LangManager.GetString("ActivationKeyDoesNotBelongToComputer"));
                }
                else if (!IsKeyNew())
                {
                    MessageBox.Show(LangManager.GetString("ActivationKeyAlreadyUsed"));
                }
                else if (!IsKeyValid())
                {
                    MessageBox.Show(LangManager.GetString("InvalidKey"));
                }
                else
                {
                    DateTime ExpiryDate = ActivateThisProduct();
                    MessageBox.Show(LangManager.GetString("ActivationDate") + ExpiryDate.ToString("dd/MM/yyyy"));
                    this.Close();
                }
            }
        }

        // Method to format PhysicalAddress to string without separators
        static string FormatMacAddress(PhysicalAddress address)
        {
            byte[] bytes = address.GetAddressBytes();
            return string.Concat(bytes.Select(b => b.ToString("X2")));
        }

        public bool IsActivationOver()
        {
            bool ActivationOver = false;

            string expiryDate = dt_ProductActivation.Rows[dt_ProductActivation.Rows.Count - 1]["ExpiryDate"].ToString();

            string format = "ddMMyyyy";

            DateTime parsedExpiryDate;

            DateTime.TryParseExact(expiryDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedExpiryDate);

            DateTime today = DateTime.Now;

            string todayDate = today.ToString("ddMMyyyy");

            if (parsedExpiryDate < today)
            {
                ActivationOver = true;
            }
            else
            {
                ActivationOver = false;
            }

            return ActivationOver;
        }

        public bool IsMACMatching()
        {
            bool MACMatching = true;

            string MACAddressFromKey = dt_ProductActivation.Rows[dt_ProductActivation.Rows.Count - 1]["MACAddress"].ToString();
            string MACAddressFromMachine = "";

            // Get actual MAC address
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Get the MAC address of Wi-Fi adapter
                if (nic.Name.Equals("Wi-Fi"))
                {
                    // Get the MAC address
                    PhysicalAddress macAddr = nic.GetPhysicalAddress();
                    MACAddressFromMachine = FormatMacAddress(macAddr);
                }
            }

            // Compare the MAC addresses
            if (MACAddressFromKey.Equals(MACAddressFromMachine))
            {
                MACMatching = true;
            }
            else
            {
                MACMatching = false;
            }

            return MACMatching;
        }

        public bool VerifyProduct(out string message)
        {
            bool ProductActivated = true;
            message = "";

            string query = "Select * from ProductActivations";

            dt_ProductActivation.Rows.Clear();

            obj_DBAccess.ReadDataThroughAdapter(query, dt_ProductActivation, null);            

            if (dt_ProductActivation.Rows.Count == 0)
            {
                message = LangManager.GetString("ProductNotActivated");
                ProductActivated = false;
            }
            else if (IsActivationOver())
            {
                message = LangManager.GetString("ActivationPeriodOver");
                ProductActivated = false;
            }
            else if (!IsMACMatching())
            {
                message = LangManager.GetString("ProductNotLinkedToComputer");
                ProductActivated = false;
            }
            else
            {
                ProductActivated = true;
            }

            return ProductActivated;
        }

        public bool LessActivationDaysRemaining()
        {
            bool LessDaysRemaining = true;

            string expiryDate = dt_ProductActivation.Rows[dt_ProductActivation.Rows.Count - 1]["ExpiryDate"].ToString();

            string format = "ddMMyyyy";

            DateTime parsedExpiryDate;

            DateTime.TryParseExact(expiryDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedExpiryDate);

            DateTime today = DateTime.Now;

            string todayDate = today.ToString("ddMMyyyy");

            DateTime pastDate = today.AddDays(-3);

            if (parsedExpiryDate < pastDate)
            {
                LessDaysRemaining = false;
            }
            else
            {
                LessDaysRemaining = true;
            }

            return LessDaysRemaining;
        }
    }
}
