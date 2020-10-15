using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace EliteBroker.DataConsumers
{
    public class LogStreamParser
    {
        private FileSystemWatcher fsw;
        private LogPathLocator logPathLocator;
        private string fileName;

        public LogStreamParser(FileSystemWatcher fsw, LogPathLocator logPathLocator, string fileName)
        {
            this.fsw = fsw;
            this.logPathLocator = logPathLocator;
            this.fileName = fileName;
            this.logPathLocator = logPathLocator;

            this.fsw.NotifyFilter |= NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;

            this.fsw.Created += Fsw_Created;
            this.fsw.EnableRaisingEvents = true;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            if (e.Name.EndsWith(".log")) {
                logPathLocator.LogStreamPath = e.Name;
            }
        }

    }
}
