using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class DockingTimeout : EventBase
    {
        public string StationName { get; set; }
    }
}
