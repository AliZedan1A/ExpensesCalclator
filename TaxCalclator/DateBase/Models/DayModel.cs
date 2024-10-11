

using System.ComponentModel.DataAnnotations;

namespace TaxCalclator.DateBase.Models
{
    public class DayModel
    {
        [Key]
        public int ID { get; set; }
        public DateOnly Date { get; set; }
        public List<ExpenseModel> Expenses { get; set; } = new();
    }
}
