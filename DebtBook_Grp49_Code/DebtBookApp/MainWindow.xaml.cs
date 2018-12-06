using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DebtBookApp.Model;
using DebtBookApp.ViewModel;

namespace DebtBookApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DebtBookViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
          /*  viewModel = new DebtBookViewModel(new NavigationService(), new DebtBook());
            DataContext = viewModel;

            Thread.Sleep(2000);

            /*viewModel.DebtBook.AddDebit("James", 2000);
            viewModel.DebtBook.AddDebit("Molly", -2000);
            viewModel.DebtBook.AddDebit("Molly",400); */
            /*viewModel.debtBook_.AddHistory("James", 2000);
            viewModel.debtBook_.AddHistory("Molly", -2000);
            viewModel.debtBook_.AddDebit("Molly",400); 

            Thread.Sleep(2000);
            viewModel.debtBook_.AddHistory("Frank", 2000); */
             // viewModel.DebtHistories.Add(new DebtHistory("Frank", 9999));
            

        }
    }
}
