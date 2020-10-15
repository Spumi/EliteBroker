using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace EliteBroker.DataConsumers
{
    public class LogPathLocator
    {
        public string LogPath { get; private set; }
        private string logStreamPath;
        public Action<string> LogpathChanged { get; set; }

        public string LogStreamPath
        {
            get { return logStreamPath; }
            set { 
                logStreamPath = value;
                if (LogpathChanged != null)
                    LogpathChanged.Invoke(value);
            }
        }


        public LogPathLocator(){
            var userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            LogPath = userDirectory + @"\Saved Games\Frontier Developments\Elite Dangerous\";

        }
    }
}
