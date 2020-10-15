using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows;

namespace EliteBroker.Models.Events
{
    public abstract class EventBase
    {
        public string EventType { get; set; }
        [JsonPropertyName("timestamp")]
        public DateTime Created { get; set; }

        [OnDeserialized]
        private void EventCreated(StreamingContext context)
        {
            MessageBox.Show(this.GetType().Name);
        }
    }
}
