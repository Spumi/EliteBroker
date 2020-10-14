using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Startup
{
    class ClearedSave : EventBase
    {
        public string Name { get; set; }
        public string Package { get; set; }
    }
}
