using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample02
{
    //publisher
    public class CreditCardBankAccount:BankAccount
    {
        public decimal Limit { get; set; }

        protected override void OnUnderBalanced(UnderBalancedEventArgs e)
        {
            var delta = this.Balance - e.Delta;
            if (Limit>10_000)
            {
                //original behavior
                base.OnUnderBalanced(e);
            }
        }
    }
}
