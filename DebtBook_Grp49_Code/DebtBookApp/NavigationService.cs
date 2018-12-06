using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DebtBookApp.ViewModel;

namespace DebtBookApp
{
    public class NavigationService
    {
        private Window currentView;

        public void OpenAddDebtHistoryView(AddDebtHistoryViewModel viewModel)
        {
            AddWindow AddDebtHistoryView = new AddWindow();
            AddDebtHistoryView.DataContext = viewModel;
            currentView = AddDebtHistoryView;
            currentView.Show();
        }

        public void OpenDisplayDebtHistoryView(DisplayDebtHistoryViewModel viewModel)
        {
            DebtHistoryWindow DisplayDebtHistoryView = new DebtHistoryWindow();
            DisplayDebtHistoryView.DataContext = viewModel;
            currentView = DisplayDebtHistoryView; 
            currentView.Show();
        }

       public void CloseView()
        {
            currentView.Close();
        }

    }
}
