using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DebtBookApp.Model;

namespace DebtBookApp.ViewModel
{
    public class DisplayDebtHistoryViewModel: ViewModelBaseClass
    { 

        private DebtBook DebtBook;

        public DisplayDebtHistoryViewModel(DebtBook debtBook)
        {
            DebtBook = debtBook;
        }

    }
}
