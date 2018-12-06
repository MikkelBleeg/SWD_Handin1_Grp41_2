using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DebtBookApp.Model;
using MvvmFoundation.Wpf;

namespace DebtBookApp.ViewModel
{
    public class DisplayDebtHistoryViewModel : BaseViewModel
    {

        #region hidden properties and ctor
        private NavigationService NavService_;
        private DebtBook debtBook_;

        private int indexInDebtBook_ { get; set; }

        public ObservableCollection<Debit> Debt
        {
            get
            {
                if(debtBook_ != null)
                    return debtBook_.DebtHistories[indexInDebtBook_].Debt;

                return new ObservableCollection<Debit>();
            }
        }


        public DisplayDebtHistoryViewModel(NavigationService navService, DebtBook debtBook, int indexInDebtBook)
        {
            NavService_ = navService;
            debtBook_ = debtBook;
            indexInDebtBook_ = indexInDebtBook;
            Debtor = debtBook_.DebtHistories[indexInDebtBook].Debtor;
        }

        public DisplayDebtHistoryViewModel()
        {
     
        }
        #endregion

        #region properties
        private string debtor_;

        public string Debtor
        {
            get => debtor_;
            set
            {
                if (debtor_ == value)
                    return;
                debtor_ = value;
            }
        }

        private long value_;

        public long Value
        {
            get => value_; set{
            if (value_ == value)
                return;
            value_ = value;
        }
        

        }

        #endregion

        #region commands
        private ICommand addNewDebitCommand_;

        public ICommand AddNewDebitCommand
        {
            get { return addNewDebitCommand_ ?? (addNewDebitCommand_ = new RelayCommand(AddNewDebit)); }
        }

        private void AddNewDebit()
        {
            debtBook_.AddDebit(Debtor, Value);
        }

        private ICommand closeCommand_;

        public ICommand CloseCommand
        {
            get { return closeCommand_ ?? (closeCommand_ = new RelayCommand(close)); }
        }

        private void close()
        {
            NavService_.CloseView();
        }

        #endregion

    }
}

