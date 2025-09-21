using System.Resources;

namespace HardwareRentalApp
{
    public partial class MainForm : Form
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(MainForm).Assembly);
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads a UserControl into the main overlay panel.
        /// If a Login control is opened, hides navigation until login is successful.
        /// </summary>
        /// <param name="childControl">The UserControl to display</param>
        public void OpenChildControl(UserControl childControl)
        {
            // ?? Step 1: Clear any existing controls in the overlay panel
            pnl_OverlayUC.Controls.Clear();

            // ?? Step 2: Configure the new UserControl
            childControl.Dock = DockStyle.Fill;   // make it fill the panel
            pnl_OverlayUC.Controls.Add(childControl); // add to panel
            childControl.BringToFront();              // bring it on top

            // ?? Step 3: Ensure focus goes to the control after it is displayed
            this.BeginInvoke((Action)(() => childControl.Focus()));

            // ?? Step 4: Update the title label (using your language manager)
            lbl_Title.Text = LangManager.GetString(childControl.Name);

            // ?? Step 5: Special case - Login control
            if (childControl is HardwareRentalApp.UserControls.Login loginUC)
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
                    //OpenChildControl(new HomeUserControl());
                };
            }
            else
            {
                // ?? Step 6: For all other controls, ensure navigation buttons are visible
                ShowButtons();
            }
        }

        public void ApplyLanguage()
        {
            this.btn_Customer.Text = LangManager.GetString("Customer");
            this.btn_Inventory.Text = LangManager.GetString("Settings");
            this.btn_Settings.Text = LangManager.GetString("Home");
            this.btn_Home.Text = LangManager.GetString("Sale");
            this.btn_Logout.Text = LangManager.GetString("Logout");
            this.btn_Sale.Text = LangManager.GetString("Inventory");
        }

        public void HideButtons()
        {
            this.btn_Settings.Visible = false;
            this.btn_Customer.Visible = false;
            this.btn_Home.Visible = false;
            this.btn_Sale.Visible = false;
            this.btn_Logout.Visible = false;
            this.btn_Inventory.Visible = false;
        }

        public void ShowButtons()
        {
            this.btn_Settings.Visible = true;
            this.btn_Customer.Visible = true;
            this.btn_Home.Visible = true;
            this.btn_Sale.Visible = true;
            this.btn_Logout.Visible = true;
            this.btn_Inventory.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //HideButtons();
            ApplyLanguage();
            OpenChildControl(new HardwareRentalApp.UserControls.Login());
        }
    }
}
