using PropertyChanged;

namespace EliteBroker.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Comodity
    {
        private int buyPrice;

        public string Id { get; set; }
        public string Name { get; set; }
        public string Name_Localised { get; set; }
        public string Category { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int MeanPrice { get; set; }
        public int StockBraket { get; set; }
        public int DemandBracket { get; set; }
        public int Stock { get; set; }
        public int Demand { get; set; }
        public bool Consumer { get; set; }
        public bool Producer { get; set; }
        public bool Rare { get; set; }
    }
}