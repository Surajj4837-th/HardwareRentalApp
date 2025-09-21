namespace HardwareRentalApp.Classes
{
    internal static class Program
    {
        public struct CustomerInfo
        {
            public string CustomerID;
            public string FirstName;
            public string Surname;
            public string MobileNum;
            public string Village;
            public string District;
            public string Pincode;
        };

        public enum Profile
        {
            Owner,
            Employee
        }

        public static class GlobalState
        {
            public static Profile e_LoginProfile;
        }

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