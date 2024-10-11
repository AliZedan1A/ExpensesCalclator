using QuestPDF.Infrastructure;
using QuestPDF.Fluent;

using TaxCalclator.DateBase.Models;
using QuestPDF.Helpers;

namespace TaxCalclator
{
    public class ExpensesPdfDocument : IDocument
    {
        private readonly List<ExpenseModel> _expenses;
        private readonly DateOnly _selectedDate;

        public ExpensesPdfDocument(List<ExpenseModel> expenses, DateOnly selectedDate)
        {
            _expenses = expenses;
            _selectedDate = selectedDate;
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.Header()
                    .Text($"مصاريف - {_selectedDate.ToString("dd/MM/yyyy")}")
                    .FontSize(20)
                    .SemiBold()
                    .AlignCenter();

                page.Content().Column(column =>
                {
                    column.Spacing(5);

                    column.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(2);
                        });

                        table.Header(header =>
                        {
                            header.Cell().Text("السعر").FontSize(14).SemiBold();
                            header.Cell().Text("سبب الشراء").FontSize(14).SemiBold();
                        });

                        foreach (var expense in _expenses)
                        {
                            table.Cell().Text(expense.Price.ToString("0.00")).FontSize(12);
                            table.Cell().Text(expense.Reson).FontSize(12);
                        }
                    });
                });

                page.Footer()
                    .AlignRight()
                    .Text($"تاريخ الطباعة: {DateTime.Now.ToString("dd/MM/yyyy")}")
                    .FontSize(10);
            });
        }
    }
}
