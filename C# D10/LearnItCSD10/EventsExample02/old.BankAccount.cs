using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample02
{
    //publisher
    //public class BankAccount
    //{
    //    public int AccountNo { get; set; }
    //    public string Name { get; set; }
    //    public decimal Balance { get; set; }

    //    public BankAccount()
    //    {
    //        AccountNo = 1234;
    //        Name = "Ali";
    //        Balance = 5000;
    //    }
    //    //
    //    public bool Debit(decimal _amount)
    //    {
    //        if (_amount > 0)
    //        {
    //            Balance += _amount;
    //            return true;
    //        }
    //        return false;
    //    }

    //    public bool Credit(decimal _amount)
    //    {
    //        var delta=_amount-Balance;
    //        if (Balance > _amount)
    //        {
    //            Balance -= _amount;
    //            return true;
    //        }
    //        else
    //        {
    //            Balance -= _amount;
    //            //fire Event
    //            OnUnderBalanced(new EventArgs());
    //            //
    //            return false;
    //        }
    //    }
    //    //
    //    public override string ToString()
    //    {
    //        return $"{AccountNo}:{Name}->{Balance}";
    //    }

    //    //Event Framework
    //    public event EventHandler underBalanced;
    //    protected virtual void OnUnderBalanced(EventArgs e)
    //    {
    //        //fire Event Here
    //        underBalanced?.Invoke(this, e);
    //    }
    //    //
    //}
}
