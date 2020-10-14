using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class DockingGranted : EventBase
    {
        public string StationName { get; set; }
        public int LandingPad { get; set; }
    }
}
