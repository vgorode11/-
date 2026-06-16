using System;

namespace FinanceTaskHelper.Classes
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }

        public Transaction(int id, DateTime date, decimal amount, string category, string type, string note)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Category = category;
            Type = type;
            Note = note;
        }

        public Transaction() { }
    }
}