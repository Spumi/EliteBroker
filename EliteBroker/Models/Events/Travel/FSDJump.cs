using System;
using System.Collections.Generic;
using System.Text;

namespace EliteBroker.Models.Events.Travel
{
    class FSDJump : EventBase
    {
        public string StarSystem { get; set; }
        public float[] StartPos { get; set; }
        /// <summary>
        /// Star's name
        /// </summary>
        public string Body { get; set; }
        public float FuelUsed { get; set; }
        public float FuelLevel { get; set; }
        public bool BoostUsed { get; set; }
        public string Faction { get; set; }
        public string FactionState { get; set; }
        public string Allegiance { get; set; }
        public string Economy { get; set; }
        public string Goverment { get; set; }
        public string Security { get; set; }
        public string Power { get; set; }
        public string PowerplayState { get; set; }


    }
}
