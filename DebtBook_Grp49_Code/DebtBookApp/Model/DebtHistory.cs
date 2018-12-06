using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookApp.Model
{
    public class DebtHistory  :NotifyPropertyImplementation
    {

        private string debtor_;
        public string   Debtor
        {
            get => debtor_;
            set
            {
                if (debtor_ == value)
                    return;
                debtor_ = value;
                NotifyPropertyChanged();
            }
        }

        private long total_;

        public long Total
        {
            get => total_;
            set
            {
                if (total_ == value)
                    return;
                total_ = value;
                NotifyPropertyChanged();
            }
        }

        public int indexInDebtBook { get; set; }

        private ObservableCollection<Debit> debt_;

        public ObservableCollection<Debit> Debt
        {
            get => debt_;
            set
            {
                if (debt_ == value)
                    return;
                debt_ = value;
                NotifyPropertyChanged();
            }
        }

        public DebtHistory(string debtor = "", long initialAmount = 0)
        {
            Debt = new ObservableCollection<Debit>();
            Debtor = debtor;

            if (initialAmount != 0)
            {
                AddDebit(initialAmount);
                NotifyPropertyChanged();
            }
        }

        public long getTotal()
        {
            long total_ = 0;
            foreach (var entry in Debt)
            {
                total_ += entry.Amount;
            }

            return total_;

        }
        
        public void AddDebit(long amount)
        {
            Debt.Add(new Debit(amount));
            NotifyPropertyChanged();
            Total = getTotal();
        }    

    }
}
