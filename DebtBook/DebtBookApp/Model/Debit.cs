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

        public Debit(string dname="", long damount = 0)
        {
            Name = dname;
            Amount = damount;
            Date = DateTime.Now;
        }

    }
}
