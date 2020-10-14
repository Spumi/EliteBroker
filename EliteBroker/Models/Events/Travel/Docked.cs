using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class Docked : EventBase
    {
        public string StationName { get; set; }
        public string StationType { get; set; }
        public string StarSystem { get; set; }
        public string Faction { get; set; }
        public string Allegiance { get; set; }
        public string Economy { get; set; }
        public string Goverment { get; set; }
        public string Security { get; set; }
    }
}
