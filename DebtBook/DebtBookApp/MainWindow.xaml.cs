using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public MainWindow()
        {
            InitializeComponent();

            List<Debit>Items=new List<Debit>();
            Items.Add(new Debit(){Name="Mette", Amount = -289});

            ViewModelLocator vwLocator = new ViewModelLocator();

            DebtBook debtBook = new DebtBook();

            debtBook.AddNewHistory("Mette", 2000);
            debtBook.AddNewHistory("Kasper", 2000);
            debtBook.AddNewHistory("Mikkel", 2000);

            DebtBookViewModel debtBookVwModel = new DebtBookViewModel(debtBook);

            DataContext = debtBookVwModel;


        }
    }
}
