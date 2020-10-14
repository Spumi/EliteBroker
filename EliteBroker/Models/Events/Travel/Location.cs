using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    /// <summary>
    /// created at startup, or when being resurrected at a station
    /// </summary>
    class Location : EventBase
    {
        public string StarSystem { get; set; }
        public float[] StartPos { get; set; }
        /// <summary>
        /// Star or planet name
        /// </summary>
        public string Body { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }
        public string FactionState { get; set; }
        public string Faction { get; set; }
        public string Allegiance { get; set; }
        public string Economy { get; set; }
        public string Government { get; set; }
        public string Security { get; set; }
        public string[] Powers { get; set; }
        public string PowerplayState { get; set; }
    }
}
