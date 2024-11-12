using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class BankAjent
    {
        public string AjentName { get; set; }
        public int AjentId { get; set; }

        public BankAjent()
        {
            AjentId = 123;
            AjentName = "khatab";
        }

        //call back
        public void WarnBankAccount(object sender, EventArgs e)
        {
            if (sender is BankAccount ba)
            {
                Console.WriteLine($"Ajent {AjentName} Warn {ba.Name} from under balanced!!");
            }
        }

        //call back
        public void WarnBankAccount(object sender, UnderBalancedEventArgs e)
        {
            if (sender is BankAccount ba && e.Delta>100)
            {
                Console.WriteLine($"Ajent {AjentName} Warn {ba.Name} from under balanced!!");
            }
        }

    }
}
