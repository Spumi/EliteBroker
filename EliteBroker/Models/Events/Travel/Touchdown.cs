using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class Touchdown : EventBase
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
