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
    public class DebtBookViewModel //:BaseViewModel
    {

        #region properties and ctor

        private NavigationService navService_;
        private DebtBook debtBook_;

        public DebtBook DebtBook
        {
            get => debtBook_;
            set
            {
                if (debtBook_ == value)
                    return;
                debtBook_ = value;
            }
        }

        public ObservableCollection<DebtHistory> DebtHistories
        {
            get => DebtBook.DebtHistories;
            
        }
        
        public DebtBookViewModel(NavigationService navService, DebtBook debtBook)
        {

            navService_ = navService;
            DebtBook = debtBook;
            IndexInDebtBook = 0;
        }

        #endregion


        #region commands
        private ICommand addClickedCommand_;

        public ICommand AddClickedCommand
        {
            get { return addClickedCommand_ ?? (addClickedCommand_ = new RelayCommand(openAddView)); }
        }

        private void openAddView()
        {
            navService_.OpenAddDebtHistoryView(new AddDebtHistoryViewModel(navService_,  debtBook_));
        }


        public int IndexInDebtBook { get; set; }

        private ICommand editClickedCommand_;

        public ICommand EditClickedCommand
        {
            get { return editClickedCommand_ ?? (editClickedCommand_ = new RelayCommand(openDisplayView)); }
        }

        private void openDisplayView()
        {

            navService_.OpenDisplayDebtHistoryView(new DisplayDebtHistoryViewModel(navService_, debtBook_, IndexInDebtBook));
        }

        #endregion
    }
}
