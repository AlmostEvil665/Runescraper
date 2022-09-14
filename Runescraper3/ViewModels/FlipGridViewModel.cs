using RunescraperObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper3.ViewModels
{
    

    internal class FlipGridViewModel : ViewModelBase
    {
        public ObservableCollection<ItemViewModel> ItemsList { get; } 


        public FlipGridViewModel()
        {
            ItemsList = new ObservableCollection<ItemViewModel>();
            Item temp = new Item();
            temp.name = "3rd age axe";
            ItemViewModel tempViewModel = new ItemViewModel(temp);
            ItemsList.Add(tempViewModel);
            temp = new Item();
            temp.name = "2nd age axe";
            tempViewModel = new ItemViewModel(temp);
            ItemsList.Add(tempViewModel);
        }

    }
}
