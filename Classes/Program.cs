namespace HardwareRentalApp.Classes
{
    public struct CustomerInfo
    {
        public long CustomerID;
        public string LesseeName;
        public string LesseeAddress;
        public string MobileNum;
    };
    public struct Items
    {
        public int ItemId { get; set; }

        public Items(int itemId) : this()
        {
            ItemId = itemId;
        }

        public string ItemName { get; set; }
        public string LocalizedName { get; set; }
        public decimal Rent { get; set; }
    }

    public enum Profile
    {
        Owner,
        Employee
    }

    public static class GlobalState
    {
        public static Profile e_LoginProfile;
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}