using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtBookApp.Model;
using DebtBookApp.ViewModel;

namespace DebtBookApp
{
    class ViewModelLocator
    {
        public DebtBookViewModel DebtBookViewModel
        {
            get => new DebtBookViewModel(new NavigationService(), new DebtBook());
        }
    }
}
