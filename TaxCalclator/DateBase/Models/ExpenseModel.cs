

using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;

namespace TaxCalclator.DateBase.Models
{
    public class ExpenseModel
    {
        [Key]
        public int Id { get; set; }
        public string Reson { get; set; }
        public double Price { get; set; }
        //Relation
        public int DayId { get; set; }
        public DayModel Day { get; set; }

    }
}
