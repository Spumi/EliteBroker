using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class DockingDenied : EventBase
    {
        public string StationName { get; set; }
        public string Reason { get; set; }
    }
}
