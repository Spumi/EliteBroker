using EliteBroker.Models;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace EliteBroker.DataConsumers
{
    public class LogReader
    {
        private string logPath;
        private FileSystemWatcher fsw;
        private MarketData market;
        
        // todo: move fsw to it's own class

        public LogReader(string path, ref MarketData market)
        {
            logPath = path;
            this.market = market;
            try
            {
                fsw = new FileSystemWatcher(path);
                fsw.Changed += new FileSystemEventHandler(FileEventHandler);
                fsw.NotifyFilter = NotifyFilters.LastWrite;
                fsw.EnableRaisingEvents = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void FileEventHandler(object sender, FileSystemEventArgs e)
        {
            string marketFile = @"Market.json";
            if (e.Name == marketFile)
            {
                market = ReadMarket(marketFile);
            }
        }

        private MarketData ReadMarket(string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            MarketData marketData = null;
            WaitForFileAccess(logPath + fileName);
            using (StreamReader file = File.OpenText(logPath + fileName))
            {
                marketData = (MarketData)serializer.Deserialize(file, typeof(MarketData));
                marketData.Items = new ObservableCollection<Comodity>(market.Items.OrderByDescending(c => c.SellPrice));
            }

            return marketData;
        }

        private void WaitForFileAccess(string fullPath)
        {
            while (true)
            {
                try
                {
                    using (StreamReader stream = new StreamReader(fullPath))
                    {
                        break;
                    }
                }
                catch
                {
                    Thread.Yield();
                }
            }
        }

    }
}
