using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace EliteBroker.Models.Events
{
    public abstract class EventBase
    {
        public string EventType { get; set; }
        [JsonPropertyName("timestamp")]
        public DateTime Created { get; set; }
    }
}
