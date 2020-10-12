using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EliteBroker.Models
{
    [AddINotifyPropertyChangedInterface]
    public class MarketData
    {
        private ObservableCollection<Comodity> items;

        public MarketData()
        {
            Items = new ObservableCollection<Comodity>();
        }

        public DateTime Date { get; set; }
        public int MarektID { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }
        public string StarSystem { get; set; }
        public ObservableCollection<Comodity> Items { get; set; }
        
    }
}
