using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper3.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public ViewModelBase FlipSuggesterVM { get; }
        public ViewModelBase ItemLookupVM { get; }

        public MainViewModel()
        {
            FlipSuggesterVM = new FlipSuggesterViewModel();
            ItemLookupVM = new ItemLookupViewModel();
        }
    }
}
