using EliteBroker.DataConsumers;
using EliteBroker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EliteBroker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal DataStore dataContext = new DataStore();

        public MainWindow()
        {
            InitializeComponent();
            MarketTab.lv.ItemsSource = dataContext.Market.Items;
            dataContext.Market.OnItemsUpdate = () =>
            {
                Dispatcher.Invoke(
                      () => MarketTab.lv.ItemsSource = dataContext.Market.Items);
            };
            dataContext.OnMarketUpdate = () =>
            {
                Dispatcher.Invoke(
                    () => MarketTab.lv.ItemsSource = dataContext.Market.Items);
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //dataContext.Market.Items.Add(new Comodity() { Name = "test", Demand = 120});
            LogPathLocator logPathLocator = new LogPathLocator();
            LogReader lr = new LogReader(logPathLocator.LogPath, ref dataContext);

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogPathLocator logPathLocator = new LogPathLocator();
            LogReader lr = new LogReader(logPathLocator.LogPath, ref dataContext);
            LogStreamParser lsp = new LogStreamParser(lr.Fsw, logPathLocator, ""); 
        }
    }
}