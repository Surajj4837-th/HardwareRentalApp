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

        }
    }
}
