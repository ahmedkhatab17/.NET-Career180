namespace EventsExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Event Handler
            //public delegate void EventHandler(object? sender, EventArgs e)
            ///sender -> data about publisher [publisher object]
            ///
            ///callback function
            ///  void fn (object s,EventArgs e){}
            #endregion

            #region EventExample V01
            BankAccount account1 = 
                new BankAccount { AccountNo = 123, Name = "Marwan", Balance = 5000 }; 
            
            BankAjent ajent1=new BankAjent(); //khattab

            //subcribe to event
            account1.underBalanced += ajent1.WarnBankAccount;
            account1.underBalanced += BlackListAccounts.AddToBlackList;
            //
            account1.Credit(5020);
            //


            BankAccount account2 =
                new BankAccount { AccountNo = 456, Name = "Sara", Balance = 10_000 };

            

            EnterpriseBankAccount enterpriseBank =
                new EnterpriseBankAccount 
                { AccountNo = 556677,
                    Name = "Abc Company",
                    Balance = 10_000
                };
            enterpriseBank.underBalanced += ajent1.WarnBankAccount;
            enterpriseBank.underBalanced += BlackListAccounts.AddToBlackList;

            enterpriseBank.Transfer(account2, 15_000);


            Console.WriteLine("-----------------------------------");
            CreditCardBankAccount creditCard1 = new CreditCardBankAccount
            {
                AccountNo = 12345,
                Name = "Waleed",
                Balance = 5000,
                Limit = 15000
            };

            creditCard1.underBalanced += ajent1.WarnBankAccount;
            creditCard1.underBalanced += BlackListAccounts.AddToBlackList;

            creditCard1.Credit(20_000);






            Console.WriteLine(BlackListAccounts.ReviewBlackListNames());

            #endregion


            #region Lab Assignments
            //1- Football Model
            //2- Bank system   ba ,ajent,blacklist,enterprise
            //3- bonus [see lab Assignment]
            #endregion
        }
    }
}

