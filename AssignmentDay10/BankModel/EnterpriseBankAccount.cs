﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class EnterpriseBankAccount:BankAccount
    {
        public bool Transfer(BankAccount employee, decimal _salary)
        {
            var delta = _salary - this.Balance;
            if(this.Balance > _salary)
            {
                employee.Balance += _salary;
                this.Balance -= _salary;
                return true;
            }
            else
            {
                employee.Balance += _salary;
                this.Balance -= _salary;
                //fire event
                OnUnderBalanced(new UnderBalancedEventArgs { Delta = delta});
                return false;
            }
        }
    }
}
