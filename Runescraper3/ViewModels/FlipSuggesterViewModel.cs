using RunescraperObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper3.ViewModels
{
    internal class FlipSuggesterViewModel : ViewModelBase
    {

        //Databinding for the grid
        public ViewModelBase FlipGridVM { get; }



        private int _CashStack;

        public int CashStack
        {
            get { return _CashStack; }
            set {
                _CashStack = value;
                OnPropertyChanged(nameof(CashStack));
            }
        }

        public FlipSuggesterViewModel()
        {
          FlipGridVM = new FlipGridViewModel();
            
          
        } 

    }
}
