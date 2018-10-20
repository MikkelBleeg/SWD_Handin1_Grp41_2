using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookApp.Model
{
    public class Debit
    {
        public string Name { get; set; }
        public long Amount { get; set; }

        public DateTime Date { get; private set; }

        public Debit(string name="", long amount = 0)
        {
            Name = name;
            Amount = amount;
            Date = DateTime.Now;
        }

    }
}
