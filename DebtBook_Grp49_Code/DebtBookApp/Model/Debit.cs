using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookApp.Model
{
    public class Debit
    {
       private long amount_;
        public long Amount
        {
            get => amount_;
            set => amount_ = value;
        }

        private DateTime date_;
        public DateTime Date
        {
            get => date_;
            set => date_ = value;
        }

        public Debit(long damount = 0)
        {
            Amount = damount;
            Date = DateTime.Now;
        }

    }
}
