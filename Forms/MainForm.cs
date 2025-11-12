using HardwareRentalApp.UserControls;
using System.Globalization;
using System.Resources;

namespace HardwareRentalApp
{
    public partial class MainForm : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(MainForm).Assembly);
        // Set the culture

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string languageCode = Properties.Settings.Default.Language;
            CultureInfo culture = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            OpenChildControl(new Login(this));
        }

        /// <summary>
        /// Loads a UserControl into the main overlay panel.
        /// If a Login control is opened, hides navigation until login is successful.
        /// </summary>
        /// <param name="childControl">The UserControl to display</param>
        public void OpenChildControl(UserControl childControl)
        {
            //  Step 1: Clear any existing controls in the overlay panel
            pnl_OverlayUC.Controls.Clear();

            //  Step 2: Configure the new UserControl
            childControl.Dock = DockStyle.Fill;   // make it fill the panel
            pnl_OverlayUC.Controls.Add(childControl); // add to panel
            childControl.BringToFront();              // bring it on top

            //  Step 3: Ensure focus goes to the control after it is displayed
            this.BeginInvoke((Action)(() => childControl.Focus()));

            //  Step 4: Update the title label (using your language manager)
            lbl_Title.Text = LangManager.GetString(childControl.Name);

            //  Step 5: Special case - Login control
            if (childControl is Login loginUC)
            {
                // Hide navigation buttons while login screen is active
                pnl_navigation.Visible = false;

                // Hook the login success event
                loginUC.LoginSuccessful += (s, e) =>
                {
                    // Remove login control once login is successful
                    pnl_OverlayUC.Controls.Clear();

                    // Show navigation panel
                    ShowButtons();

                    // Load the default Home screen
                    pnl_navigation.Visible = true;
                    ApplyLanguage(LangManager.GetString(childControl.Name));
                    OpenChildControl(new Home());
                };
            }
            else
            {
                //  Step 6: For all other controls, ensure navigation buttons are visible
                ShowButtons();
            }
        }

        public void ApplyLanguage(string ChildControlName = null)
        {
            this.btn_Customers.Text = LangManager.GetString("Customers");
            this.btn_Inventory.Text = LangManager.GetString("Inventory");
            this.btn_Home.Text = LangManager.GetString("Home");
            this.btn_Logout.Text = LangManager.GetString("Logout");

            if (ChildControlName != null)
                lbl_Title.Text = ChildControlName;
        }

        public void HideButtons()
        {
            this.btn_Customers.Visible = false;
            this.btn_Home.Visible = false;
            this.btn_Logout.Visible = false;
            this.btn_Inventory.Visible = false;
        }

        public void ShowButtons()
        {
            this.btn_Customers.Visible = true;
            this.btn_Home.Visible = true;
            this.btn_Logout.Visible = true;
            this.btn_Inventory.Visible = true;

            this.pnl_Title.BackColor = Color.FromArgb(202, 244, 144);   //Assign label with home button color upon login
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.pnl_Title.BackColor = Color.FromArgb(202, 244, 144);
            OpenChildControl(new Home());
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            this.pnl_Title.BackColor = Color.FromArgb(253, 124, 217);
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            this.pnl_Title.BackColor = Color.FromArgb(252, 255, 233);
            OpenChildControl(new Customers());
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            this.pnl_Title.BackColor = Color.FromArgb(102, 239, 209);
            OpenChildControl(new Inventory());
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.pnl_Title.BackColor = Color.FromArgb(129, 152, 223);
        }

        private void btn_Home_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Home.BackColor = Color.FromArgb(202, 244, 144);
            this.btn_Home.ForeColor = Color.Black;
            this.btn_Home.Font = new System.Drawing.Font("Nirmala UI", 16, System.Drawing.FontStyle.Bold);
        }

        private void btn_Home_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Home.BackColor = Color.FromArgb(51, 51, 76);
            this.btn_Home.ForeColor = Color.Gainsboro;
            this.btn_Home.Font = new System.Drawing.Font("Nirmala UI", 14, System.Drawing.FontStyle.Regular);
        }

        private void btn_Customers_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Customers.BackColor = Color.FromArgb(252, 255, 233);
            this.btn_Customers.ForeColor = Color.Black;
            this.btn_Customers.Font = new System.Drawing.Font("Nirmala UI", 16, System.Drawing.FontStyle.Bold);
        }

        private void btn_Customers_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Customers.BackColor = Color.FromArgb(51, 51, 76);
            this.btn_Customers.ForeColor = Color.Gainsboro;
            this.btn_Customers.Font = new System.Drawing.Font("Nirmala UI", 14, System.Drawing.FontStyle.Regular);
        }

        private void btn_Inventory_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Inventory.BackColor = Color.FromArgb(102, 239, 209);
            this.btn_Inventory.ForeColor = Color.Black;
            this.btn_Inventory.Font = new System.Drawing.Font("Nirmala UI", 16, System.Drawing.FontStyle.Bold);
        }

        private void btn_Inventory_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Inventory.BackColor = Color.FromArgb(51, 51, 76);
            this.btn_Inventory.ForeColor = Color.Gainsboro;
            this.btn_Inventory.Font = new System.Drawing.Font("Nirmala UI", 14, System.Drawing.FontStyle.Regular);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
