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
    public class DebtBookViewModel : ViewModelBaseClass
    {
        private DebtBook DebtBook;

        public DebtBookViewModel(DebtBook debtBook)
        {
            DebtBook = debtBook;
        }

        public List<DebtHistory> DebtsHistories
        {
            get
            {
                return DebtBook.DebtsHistories;
            }
            
        }

    }
}
