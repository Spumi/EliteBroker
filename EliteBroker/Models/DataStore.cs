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
        public MarketData Market { get; set; }

        public DataStore()
        {
            Market = new MarketData();
        }

    }
}
