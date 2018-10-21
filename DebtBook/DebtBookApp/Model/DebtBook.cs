using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookApp.Model
{
    public class DebtBook
    {
         ICollection<DebtHistory> Debts_ => new List<DebtHistory>();

        public  List<DebtHistory> DebtsHistories
        {
            get { return (List<DebtHistory>) Debts_;}
        }

        public void AddNewHistory(string debtor = "", long initialAmount = 0)
        {
            Debts_.Add(new DebtHistory(debtor, initialAmount));
        }

        public void AddDebit(string debtor = "", long amount = 0)
        {
            foreach (var history in Debts_)
            {
                if (history.Debtor == debtor)
                {
                    history.AddDebit(debtor,amount);
                }
            }
        }

    }
}
