using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample02
{
    public class UnderBalancedEventArgs:EventArgs
    {
        public decimal Delta { get; set; }
        public DateTime TimeStamp { get; } = DateTime.Now;

    }
}
