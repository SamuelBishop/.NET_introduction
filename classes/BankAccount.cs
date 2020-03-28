using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
        // properties of the bank account class
        public string Number { get; } // the state and behavior
        public string Owner { get; set; }
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }
        private static int accountNumberSeed = 1234567890; // only accessable through the bank account class
        public BankAccount(string name, decimal initialBalance){ // constructor (create object using new)
            this.Owner = name;
            //this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString(); // converts from int to string
            accountNumberSeed++;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        private List<transaction> allTransactions = new List<transaction>();
        public void MakeDeposit(decimal amount, DateTime date, string note )
        { // method belonging to bank account object
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");            
            }
            var deposit = new transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note )
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");            
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");           
            }
            var withdrawal = new transaction(amount, date, note);
            allTransactions.Add(withdrawal);
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
