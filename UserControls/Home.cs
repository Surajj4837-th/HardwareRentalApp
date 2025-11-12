using System.Resources;

namespace HardwareRentalApp.UserControls
{
    public partial class Home : UserControl
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Home).Assembly);
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btn_SaveFilePath.Text = LangManager.GetString("FileSavingPath");

            // Load saved path when the app starts
            string savedPath = Properties.Settings.Default.SaveDirectory;

            if (!string.IsNullOrEmpty(savedPath) && Directory.Exists(savedPath))
            {
                lbl_FilePath.Text = savedPath;
            }
            else
            {
                lbl_FilePath.Text = "---------------------";
            }

            tt_SavePath.SetToolTip(lbl_FilePath, lbl_FilePath.Text);
        }

        private void btn_SaveFilePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = LangManager.GetString("FileSavingPath");
                folderDialog.ShowNewFolderButton = true;

                // Show the dialog and wait for user selection
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    // Display it on the label
                    lbl_FilePath.Text = selectedPath;

                    // Save it to app settings
                    Properties.Settings.Default.SaveDirectory = selectedPath;
                    Properties.Settings.Default.Save(); // persist it
                }
            }
        }
    }
}
