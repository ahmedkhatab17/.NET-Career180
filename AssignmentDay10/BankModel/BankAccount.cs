using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class BankAccount
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }


        public BankAccount()
        {
            AccountNo = 1234;
            Name = "ali";
            Balance = 5000;
        }

        public bool Depit(decimal _amount)
        {
            if (_amount > 0)
            {
                Balance += _amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Credit(decimal _amount)
        {
            var delta = _amount - Balance;
            if (Balance > _amount)
            {
                Balance -= _amount;
                return true;
            }
            else
            {
                Balance -= _amount;
                //fire evnt
                OnUnderBalanced(new UnderBalancedEventArgs{ Delta = delta });
                return false;
            }
        }


        public override string ToString()
        {
            return $"{AccountNo}:{Name}-->{Balance}";
        }

        public event EventHandler<UnderBalancedEventArgs> UnderBalanced;

        protected virtual void OnUnderBalanced(UnderBalancedEventArgs e)
        {
            //fire event
            UnderBalanced?.Invoke(this, e);

        }
    }
}
