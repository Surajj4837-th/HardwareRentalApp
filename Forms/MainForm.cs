namespace HardwareRentalApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OpenChildControl(UserControl childControl)
        {
            // Clear any existing controls in the panel
            pnl_OverlayUC.Controls.Clear();

            // Prepare the child control
            childControl.Dock = DockStyle.Fill;
            childControl.Visible = true;
            childControl.Enabled = true;

            // Add to panel
            pnl_OverlayUC.Controls.Add(childControl);
            childControl.BringToFront();

            // Optional: set focus after it’s fully loaded
            this.BeginInvoke((Action)(() =>
            {
                childControl.Focus();
            }));

            // Optional: update title label if the control has a "Title" property
            //lbl_Title.Text = LangManager.GetString(childControl.Name);

            // Show/hide buttons based on the control type
            //if (childControl is HardwareRentalApp.UserControls.Login)
            //{
            //    HideButtons();
            //}
            //else
            //{
            //    ShowButtons();
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildControl(new HardwareRentalApp.UserControls.Login());
        }
    }
}
