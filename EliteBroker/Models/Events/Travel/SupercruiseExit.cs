using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class SupercruiseExit : EventBase
    {
        public string StarSystem { get; set; }
        public string Body { get; set; }
        public string BodyType { get; set; }
    }
}
