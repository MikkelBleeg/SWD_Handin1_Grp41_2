using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DebtBookApp.Model;
using MvvmFoundation.Wpf;

namespace DebtBookApp.ViewModel
{
    public class AddDebtHistoryViewModel : BaseViewModel
    {
        #region  properties and ctor
        private string debtor_;
        public string Debtor { get => debtor_;
            set
            {
                if (debtor_ == value)
                    return;
                debtor_ = value;
            }
        }

        private long initialAmount_;
        public long InitialAmount { get => initialAmount_;
            set
            {
                if (initialAmount_ == value)
                    return;
                initialAmount_ = value;
            }
            
        }

        private NavigationService NavService_;
        private DebtBook debtBook_;

        public AddDebtHistoryViewModel(NavigationService navService, DebtBook debtBook)
        {
            NavService_ = navService;
            debtBook_ = debtBook;
        }
        public AddDebtHistoryViewModel()
        {

        }

        #endregion

        #region commands

        private ICommand saveCommand_;

        public ICommand SaveCommand
        {
            get { return saveCommand_ ?? (saveCommand_ = new RelayCommand(addNewDebtHistory)); }
        }

        private void addNewDebtHistory()
        {
            debtBook_.AddHistory(Debtor, InitialAmount);
            closeView();
        }

        private ICommand cancelCommand_;

        public ICommand CancelCommand
        {
            get { return cancelCommand_ ?? (cancelCommand_ = new RelayCommand(closeView)); }
        }

        private void closeView()
        {
            NavService_.CloseView();
        }

        #endregion
    }
}
