namespace BankModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount { AccountNo = 123, Name = "omar", Balance = 5000 };

            BankAjent ajent1 = new BankAjent();

            account1.UnderBalanced += ajent1.WarnBankAccount;
            account1.UnderBalanced += BlackListAccounts.AddToBlackList;
            
            account1.Credit(5110);

            Console.WriteLine(BlackListAccounts.ReviewBlackListNames());

            //////////////////////////////////
            BankAccount account2 = new BankAccount { AccountNo = 111, Name = "arwa", Balance = 10000 };

            EnterpriseBankAccount enterpriseBank =
                new EnterpriseBankAccount
                {
                    AccountNo = 654321,
                    Name = "Abc Company",
                    Balance = 10_000
                };
            enterpriseBank.UnderBalanced += ajent1.WarnBankAccount;
            enterpriseBank.UnderBalanced += BlackListAccounts.AddToBlackList;

            enterpriseBank.Transfer(account2, 15000);
            //Console.WriteLine(BlackListAccounts.ReviewBlackListNames());
            /////////////////////////////////
            Console.WriteLine("-----------------------------------");
            CreditCardBankAccount creditCard1 = new CreditCardBankAccount
            {
                AccountNo = 12345,
                Name = "Waleed",
                Balance = 5000,
                Limit = 15000
            };

            creditCard1.UnderBalanced += ajent1.WarnBankAccount;
            creditCard1.UnderBalanced += BlackListAccounts.AddToBlackList;

            creditCard1.Credit(20_000);

            Console.WriteLine(BlackListAccounts.ReviewBlackListNames());

        }
    }
}
