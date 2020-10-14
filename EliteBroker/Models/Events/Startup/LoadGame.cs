using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace EliteBroker.Models.Events.Startup
{
    class LoadGame : EventBase
    {
        [JsonPropertyName("Commander")]
        public string Name { get; set; }
        public string Ship { get; set; }
        public string ShipID { get; set; }
        public string GameMode { get; set; }
        public string Group { get; set; }
        public long Credits { get; set }
        public long Loan { get; set; }
    }
}
