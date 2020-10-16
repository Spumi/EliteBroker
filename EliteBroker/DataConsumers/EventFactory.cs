﻿using System;

namespace EliteBroker.DataConsumers
{
    public class EventFactory
    {
        internal void GenerateEvent(string eventType)
        {
            //testing.. will be used for event object generations
            //TODO: Change event namespaces to simplify code
            System.Windows.MessageBox.Show(Type.GetType("EliteBroker.Models.Events.Travel." + eventType).FullName);
        }
    }
}