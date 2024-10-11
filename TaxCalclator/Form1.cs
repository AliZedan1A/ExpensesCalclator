using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TaxCalclator.DateBase;
using TaxCalclator.DateBase.Models;

namespace TaxCalclator
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        public Form1()
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            InitializeComponent();
        }

        private void BtnSrch_Click(object sender, EventArgs e)
        {

            DateOnly dt = DateOnly.FromDateTime(this.DayDateTime.Value.Date);
            var day = db.Days.Where(d => d.Date == dt).Include(x => x.Expenses).FirstOrDefault();
            if (day != null)
            {
                var dayexp = day.Expenses.Select(expense => new
                {
                    expense.Id,
                    expense.Reson,
                    expense.Price,

                }).ToList();
                DayClcGrid.DataSource = dayexp;
                double Price = dayexp.Sum(d => d.Price);
                ContentLable.Text = $"day Expense : {Price}";


            }
            else
            {
                DayClcGrid.DataSource = null;
                ContentLable.Text = "There Is No Data";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (AddTextBox.Text == string.Empty)
            {
                ContentLable.Text = "Price Input Requred"; return;
            }

            if (resontext.Text == string.Empty)
            {
                ContentLable.Text = "Resoh Input Requred"; return;
            }
            DateOnly dt = DateOnly.FromDateTime(this.AddDateTime.Value.Date);
            var day = db.Days.Include(x => x.Expenses).SingleOrDefault(x => x.Date == dt);

            if (day != null)
            {

                day.Expenses.Add(new DateBase.Models.ExpenseModel() { DayId = day.ID, Reson = resontext.Text, Price = double.Parse(AddTextBox.Text) });
            }
            else
            {

                day = new DayModel { Date = dt, Expenses = new List<ExpenseModel>() };
                day.Expenses.Add(new DateBase.Models.ExpenseModel() { Reson = resontext.Text, Price = double.Parse(AddTextBox.Text) });

                db.Days.Add(day);
            }

            db.SaveChanges();
            ContentLable.Text = $"{double.Parse(AddTextBox.Text)} Added";
        }

        private void AddTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex NumberValdition = new Regex("^\\d+(\\.\\d*)?$");
            if (!NumberValdition.IsMatch(AddTextBox.Text))
            {
                AddTextBox.Text = string.Empty;
            }
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            if (db.Days.Count() == 0)
            {
                ContentLable.Text = "No Data";
                return;
            }
            var list = db.Days.Include(x => x.Expenses).ToList();
            List<ListModel> f = new List<ListModel>();
            foreach (var item in list)
            {
                var dayexp = item.Expenses.Select(expense => new
                {
                    expense.Id,
                    expense.Price
                }).ToList();
                f.Add(new ListModel() { Day = item.Date, FainlePrice = dayexp.Sum(x => x.Price) });
            }
            var sortedList = f.OrderBy(x => x.Day).ToList();

            AllClcGrid.DataSource = sortedList;
            AllclcText.Text = f.Sum(x => x.FainlePrice).ToString();
            ContentLable.Text = "Done.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DeleteText.Text == string.Empty|| DayClcGrid.SelectedCells[0] ==null)
            {
                if(DayClcGrid.SelectedCells[0].ColumnIndex == 0)
                {
                    var exp1 = db.Expenses.SingleOrDefault(x => x.Id == (int)DayClcGrid.SelectedCells[0].Value);
                    if (exp1 != null)
                    {
                        DateOnly dt = DateOnly.FromDateTime(this.DayDateTime.Value.Date);
                        var day = db.Days.Where(d => d.Date == dt).Include(x => x.Expenses).FirstOrDefault();
                        db.Expenses.Remove(exp1);
                        db.SaveChanges();
                        if (day != null)
                        {
                            var dayexp = day.Expenses.Select(expense => new
                            {
                                expense.Id,
                                expense.Reson,
                                expense.Price,

                            }).ToList();
                            DayClcGrid.DataSource = dayexp;
                            double Price = dayexp.Sum(d => d.Price);
                        }
                        ContentLable.Text = $"Expens id {exp1.Id}Deleted";
                    }
                    else
                    {
                        ContentLable.Text = $"Expens id Not Found";
                    }
                }
                
                ContentLable.Text = "Select Delete Id";
                return;
            }
            var exp = db.Expenses.SingleOrDefault(x => x.Id == int.Parse(DeleteText.Text));
            if (exp != null)
            {
                DateOnly dt = DateOnly.FromDateTime(this.DayDateTime.Value.Date);
                var day = db.Days.Where(d => d.Date == dt).Include(x => x.Expenses).FirstOrDefault();
                db.Expenses.Remove(exp);
                db.SaveChanges();
                if (day != null)
                {
                    var dayexp = day.Expenses.Select(expense => new
                    {
                        expense.Id,
                        expense.Reson,
                        expense.Price,

                    }).ToList();
                    DayClcGrid.DataSource = dayexp;
                    double Price = dayexp.Sum(d => d.Price);
                }
                ContentLable.Text = $"Expens id {exp.Id}Deleted";
            }
            else
            {
                ContentLable.Text = $"Expens id Not Found";
            }
        }

        private void DeleteText_TextChanged(object sender, EventArgs e)
        {
            Regex NumberValdition = new Regex("^\\d+(//*)?$");
            if (!NumberValdition.IsMatch(DeleteText.Text))
            {
                DeleteText.Text = string.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateOnly dt = DateOnly.FromDateTime(this.DayDateTime.Value.Date);
            var day =  db.Days.Where(x => x.Date == dt).Include(x => x.Expenses).FirstOrDefault();
            if( day is null|| day.Expenses.Count == 0)
            {
                ContentLable.Text = "there is no data ";
                return;
            }

            ExpensesPdfDocument pdf = new ExpensesPdfDocument(day.Expenses, day.Date);
            Random r = new Random();
            var random =  r.Next(8000);

            pdf.GeneratePdf($"{random}.pdf");
            ContentLable.Text = $"done create pdf\n{random}.pdf";
            return;


        }
    }
}
