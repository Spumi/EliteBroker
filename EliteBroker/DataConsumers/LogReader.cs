using EliteBroker.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace EliteBroker.DataConsumers
{
    public class LogReader
    {
        private string logPath;
        private FileSystemWatcher fsw;
        private MarketData market;

        public LogReader(string path, ref MarketData market)
        {
            logPath = path;
            this.market = market;
            try
            {
                fsw = new FileSystemWatcher(path);
                fsw.Changed += new FileSystemEventHandler(FileEventHandler);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void FileEventHandler(object sender, FileSystemEventArgs e)
        {
            if (e.Name == @"Market.json")
            {
                market = ReadMarket();
            }
        }

        private MarketData ReadMarket()
        {
            throw new NotImplementedException();
        }
    }
}
