using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookApp.Model
{
    public class DebtHistory
    {
        private ICollection<Debit> Debt => new List<Debit>();

        public DebtHistory(string debtor = "", long initialAmount = 0)
        {
            Debtor = debtor;

            if (initialAmount != 0)
            {
                Debt.Add(new Debit(debtor,initialAmount));
            }

        }
        public string Debtor { get; set; }

        public long Total
        {
            get
            {
                long total_ = 0;

                foreach (var amount in Debt)
                {
                    total_ += amount.Amount;
                }

                return total_;
            }
        }
        
        public void AddDebit(string debit,long amount)
        {
            Debt.Add(new Debit(debit,amount));
        }


        public class Amounts : ObservableCollection<int>
        {
            public Amounts()
            {
                Add(100);
                Add(-250);
                Add(-100);
                Add(250);
                Add(300);
                Add(-300);
            }
            
        }
    }
}
