using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Header
{
    class LogInit : EventBase
    {
        public int Part { get; set; }
        public string Language { get; set; }
        public string Version { get; set; }
        public string Build { get; set; }
    }
}
