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
        public string ItemName { get; set; }
        public string LocalizedName { get; set; }
        public decimal Rent { get; set; }
        public Int32 MinRentDays { get; set; }
    }
    public class BillItemSummary
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Rent { get; set; }
        public decimal Total { get; set; }
    }

    public struct CompanyInfo
    {
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string GSTNumber { get; set; }
    }
    public struct BillSummary
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime BillDate { get; set; }
        public string OwnerName { get; set; }
        public string Reference { get; set; }
        public string WorkLocation { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
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