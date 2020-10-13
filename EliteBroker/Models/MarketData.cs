using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls.Primitives;

namespace EliteBroker.Models
{
    [AddINotifyPropertyChangedInterface]
    public class MarketData : INotifyPropertyChanged
    {
        private ObservableCollection<Comodity> items;

        public MarketData()
        {
            OnItemsUpdate = () => { };
            Items = new ObservableCollection<Comodity>();
            Items.CollectionChanged += Items_CollectionChanged;
        }

        public DateTime Date { get; set; }
        public int MarektID { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }
        public string StarSystem { get; set; }
        public Action OnItemsUpdate { get; set; }
        public ObservableCollection<Comodity> Items { 
            get => items;
            set {
                items = value;
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            OnItemsUpdate.Invoke();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }




        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("Items");
        }


    }
}
