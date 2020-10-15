using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace EliteBroker.DataConsumers
{
    public class LogPathLocator
    {
        public string LogPath { get; private set; }
        public string LogStreamPath { get; set; }

        public LogPathLocator(){
            var userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            LogPath = userDirectory + @"\Saved Games\Frontier Developments\Elite Dangerous\";
        }
    }
}
