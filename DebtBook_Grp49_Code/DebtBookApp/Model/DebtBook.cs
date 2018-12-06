using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookApp.Model
{
    public class DebtBook :NotifyPropertyImplementation
    {
        private ObservableCollection<DebtHistory> histories_;
        public ObservableCollection<DebtHistory> DebtHistories
        {
            get => histories_;
            set
            {
                if (histories_ == value)
                    return;

                histories_ = value;
                NotifyPropertyChanged();
            }
        }

        public DebtBook()
        {
          DebtHistories = new ObservableCollection<DebtHistory>();
        }


        public void AddHistory(string debtor, long initialAmount)
        {
            DebtHistory newHistory = new DebtHistory(debtor, initialAmount);
            DebtHistories.Add(newHistory);
            NotifyPropertyChanged();

        }

        public void AddDebit(string debtor, long amount)
        {
            foreach (var history in DebtHistories)
            {
                if (history.Debtor == debtor)
                {
                    history.AddDebit(amount);
                }
            }

            NotifyPropertyChanged();
        }
    }
}
