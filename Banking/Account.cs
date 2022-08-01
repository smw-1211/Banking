using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        private int accountId;
        private string holdersName;
        private double balance;

        public Account(int accountId, string holdersName, double balance)
        {
            this.accountId = accountId;
            this.holdersName = holdersName;
            this.balance = balance;
        }
        public Account(int accountId, string holdersName)
        {
            this.accountId = accountId;
            this.holdersName = holdersName;
            this.balance = 0;
        }

        public int AccountId { get => accountId; }
        public string HoldersName { get => holdersName; set => holdersName = value; }

        public double Balance 
        { 
            get => balance;
            protected set => balance = value;
        }
        public bool Deposit(double amount)
        {
            balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            balance -= amount;
            return true;
        }

        
    }
}
