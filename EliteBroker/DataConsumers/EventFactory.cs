using System;

namespace EliteBroker.DataConsumers
{
    public class EventFactory
    {
        internal void GenerateEvent(string eventType)
        {
            //testing.. will be used for event object generations
            System.Windows.MessageBox.Show(Type.GetType("EliteBroker.Models.Events.Travel." + eventType).FullName);
        }
    }
}