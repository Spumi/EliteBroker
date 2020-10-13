using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls.Primitives;

namespace EliteBroker.Models
{
    [AddINotifyPropertyChangedInterface]
    public class MarketData 
    {
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
