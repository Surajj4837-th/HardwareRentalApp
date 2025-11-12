using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Resources;

namespace HardwareRentalApp.Classes
{
    internal class BillSaver : IDocument
    {
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(BillSaver).Assembly);
        private readonly BillSummary _BillInformation;
        private readonly List<BillItemSummary> _BillItems;

        private CompanyInfo CompanyInformation = new CompanyInfo()
        {
            CompanyName = "ABC Hardware Rentals",
            AddressLine1 = "123 Main Street",
            AddressLine2 = "Mumbai, Maharashtra",
            GSTNumber = "27AAEPM1234C1Z5"
        };

        public BillSaver(BillSummary BillInformation, List<BillItemSummary> BillItems)
        {
            _BillInformation = BillInformation;
            _BillItems = BillItems;
            QuestPDF.Settings.License = LicenseType.Community;
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.A4);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Header().Text(LangManager.GetString("TaxInvoice")).SemiBold().FontSize(18).AlignCenter();

                page.Content().PaddingVertical(10).Column(column =>
                {
                    // Company & Customer Info
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text(CompanyInformation.CompanyName).SemiBold();
                            col.Item().Text(CompanyInformation.AddressLine1);
                            col.Item().Text(CompanyInformation.AddressLine2);
                            col.Item().Text("Maharashtra, India");
                            col.Item().Text($"GST: {CompanyInformation.GSTNumber}");
                        });

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("Bill To:").SemiBold();
                            col.Item().Text(_BillInformation.CustomerName);
                            col.Item().Text("Maharashtra, India");
                        });
                    });

                    column.Item().Container().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                    // Invoice Meta Info
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text(LangManager.GetString("InvoiceID") + $": {_BillInformation.BillId}");
                            //col.Item().Text(LangManager.GetString("AdminID") + $": {_data.AdminID}");
                        });
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text(LangManager.GetString("BillDate") + $": {_BillInformation.PaymentDate:dd/MM/yyyy}");
                        });
                    });

                    column.Item().PaddingVertical(5);

                    // Table Header
                    column.Item().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(50);  // Sr. No.
                            cols.RelativeColumn();    // Item
                            cols.ConstantColumn(50);  // Quantity
                            cols.ConstantColumn(50);  // Rent
                            cols.ConstantColumn(80);  // RentalDays
                            cols.ConstantColumn(70);  // Amount
                        });

                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text(LangManager.GetString("SrNo"));
                            header.Cell().Element(CellStyle).Text(LangManager.GetString("ItemName"));
                            header.Cell().Element(CellStyle).Text(LangManager.GetString("Quantity"));
                            header.Cell().Element(CellStyle).Text(LangManager.GetString("Rent"));
                            header.Cell().Element(CellStyle).Text(LangManager.GetString("RentalDays"));
                            header.Cell().Element(CellStyle).Text(LangManager.GetString("Amount"));

                            static IContainer CellStyle(IContainer container) =>
                                container.DefaultTextStyle(x => x.SemiBold()).Padding(2).Background(Colors.Grey.Lighten2).Border(1);
                        });

                        int sr = 1;
                        foreach (var item in _BillItems)
                        {
                            table.Cell().Element(CellBody).Text(sr++.ToString());
                            table.Cell().Element(CellBody).Text(item.ItemName);
                            table.Cell().Element(CellBody).Text(item.Quantity.ToString());
                            table.Cell().Element(CellBody).Text(item.Rent.ToString("0.00"));
                            table.Cell().Element(CellBody).Text(item.RentalDays.ToString("0.00"));
                            table.Cell().Element(CellBody).Text(item.Total.ToString("0.00"));

                            static IContainer CellBody(IContainer container) =>
                                container.BorderBottom(1).Padding(2);
                        }
                    });

                    column.Item().PaddingTop(10).AlignRight().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.RelativeColumn();
                            cols.ConstantColumn(100);
                        });

                        table.Cell().Text(LangManager.GetString("TotalAmount") + ": ").Bold();
                        table.Cell().AlignRight().Text(_BillInformation.TotalAmount.ToString("0.00")).Bold();
                    });
                });

                page.Footer()
                    .AlignCenter()
                    .Text(txt => txt.Span(LangManager.GetString("ThankYou")).FontSize(10));
            });
        }
    }
}
