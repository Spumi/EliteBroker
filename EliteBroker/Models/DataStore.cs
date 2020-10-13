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
        public Action OnMarketUpdate { get; set; }
        private MarketData market;
        public MarketData Market { 
            get => market;
            set { 
                market = value;
                if (OnMarketUpdate != null)
                    OnMarketUpdate.Invoke();
            } 
        }

        public DataStore()
        {
            Market = new MarketData();
        }

    }
}
