using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD08
{
    public class NetworkCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        private NetworkCard()
        {
            Id = 10;
            Name = "Intel";
            Year = 2015;
        }

        //////////Create single object from class by c++ version
        static NetworkCard card;
        //getter
        public static NetworkCard CreateObject()
        {
            if (card == null)  //not exists
            {
                card = new NetworkCard();
            }
            return card;
        }
        //

    }
}
