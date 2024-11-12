using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class UnderBalancedEventArgs:EventArgs
    {
        public decimal Delta {  get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;



    }
}
