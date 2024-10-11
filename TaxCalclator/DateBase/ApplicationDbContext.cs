
using Microsoft.EntityFrameworkCore;
using TaxCalclator.DateBase.Models;

namespace TaxCalclator.DateBase
{
    public class ApplicationDbContext : DbContext
    {
        public string DbPath { get; }
    
        public ApplicationDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "CalcDb.db");

        }
        public DbSet<DayModel> Days { get; set; }
        public DbSet<ExpenseModel> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite($"Data Source={DbPath}");   
        }
    }
}
