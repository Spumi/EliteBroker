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
        private long lastPos = 0;
        public EventFactory EventFactory { get; set; }

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
            logPathLocator.LogpathChanged = LogPathChanged;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            if (e.Name.EndsWith(".log")) {
                logPathLocator.LogStreamPath = e.Name;
            }
        }

        public void LogPathChanged(string path) {
            fsw.Changed += PollEvents;
        }

        private void PollEvents(object source, FileSystemEventArgs logFile)
        {
            if (logFile.Name == logPathLocator.LogStreamPath){
                Utils.FileUtils.WaitForFileAccess(logFile.FullPath);
                try
                {
                    using (StreamReader file = File.OpenText(logFile.FullPath))
                    {
                        file.BaseStream.Seek(lastPos , SeekOrigin.Begin);
                        //marketData = (MarketData)serializer.Deserialize(file, typeof(MarketData));
                        //marketData.Items = new ObservableCollection<Comodity>(marketData.Items);
                        //MessageBox.Show(file.ReadLine());
                        EventFactory.GenerateEvent(file.ReadLine());
                        lastPos = file.BaseStream.Position;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
