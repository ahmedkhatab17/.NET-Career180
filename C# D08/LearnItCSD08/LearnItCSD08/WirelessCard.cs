using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD08
{
    public class WirelessCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        private WirelessCard()
        {
            Id = 10;
            Name = "Intel";
            Year = 2015;
        }

        #region SingleTon via c# technique
        //v1
        //static WirelessCard card;
        //public static WirelessCard Card
        //{
        //    get
        //    {
        //        if (card == null) { card = new WirelessCard(); }
        //        return card;
        //    }
        //}

        ////v2
        //public static WirelessCard Card { get;}
        ////static ctor :fn to initialize static members
        ////static ctor called once per prorram call EVER
        //static WirelessCard()
        //{
        //    Card= new WirelessCard();
        //}

        //v3 enhancement for V2
        public static WirelessCard Card { get; }
            = new WirelessCard();
        #endregion
    }
}
