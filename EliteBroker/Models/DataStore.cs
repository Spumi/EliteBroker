using EliteBroker.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker
{
    [AddINotifyPropertyChangedInterface]
    public class DataStore
    {
        public DataStore()
        {
            Market = new MarketData();
        }

        public MarketData Market { get; set; }
    }
}
