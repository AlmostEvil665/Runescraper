using RunescraperObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper3.ViewModels
{
    internal class ItemViewModel : ViewModelBase
    {

        private Item thisItem;
        private int _ID => thisItem.ID;
        private int _high => thisItem.high;
        private int _low => thisItem.low;
        private int _limit => thisItem.limit;
        private string _name => thisItem.name;
        private int _volume => thisItem.volume;


        public int ID
        {
            get { return _ID; }
            set
            {
                
                OnPropertyChanged(nameof(ID));
            }
        }
        public int BuyPrice
        {
            get { return _high; }
            set
            {
                
                OnPropertyChanged(nameof(BuyPrice));
            }
        }
        public int SellPrice
        {
            get { return _low; }
            set
            {
               
                OnPropertyChanged(nameof(SellPrice));
            }
        }
        public int BuyLimit
        {
            get { return _limit; }
            set
            {
              
                OnPropertyChanged(nameof(BuyLimit));
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
              
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Volume
        {
            get { return _volume; }
            set
            {
               
                OnPropertyChanged(nameof(Volume));
            }
        }

        public ItemViewModel(Item item)
        {
            thisItem = item;
        }
    }
}
