using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // making bank accounts
            var account1 = new BankAccount("Sam", 1000);
            var account2 = new BankAccount("Alfred", 5000);
            Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance.");
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

            // making transactions
            account1.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account1.Balance);
            account1.MakeDeposit(100, DateTime.Now, "Alfred hit me with the venmo");
            Console.WriteLine(account1.Balance);

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            // try catch for negative balance
            try
            {
                account1.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account1.GetAccountHistory());
        }
    }
}
