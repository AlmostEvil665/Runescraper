using Runescraper3.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Runescraper3.ViewModels
{
    internal class ItemLookupViewModel : ViewModelBase
    {

        public ICommand _ScrapeItemsCommand { get; }

        public ItemLookupViewModel()
        {
            _ScrapeItemsCommand = new ScrapeItemsCommand();
        }
    }
}
