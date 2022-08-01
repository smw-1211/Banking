using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class SavingsAccount :Account
    {
       
       private double minimumBalance;
       public SavingsAccount(int accountId, string holdersName, double balance, double minimumBalance)
            :base(accountId, holdersName, balance)
        {
            this.minimumBalance = minimumBalance;
        }

        public double MinimumBalance { get => minimumBalance; }

        public bool Withdraw(double amount)
        {
            if ((Balance-minimumBalance) < amount)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
    }
}
