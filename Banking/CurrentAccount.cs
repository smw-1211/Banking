using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class CurrentAccount : Account
    {
        private double overDraft;
        public CurrentAccount(int accountId, string holdersName, double balance, double overdraft)
            : base(accountId, holdersName, balance)
        {
            this.overDraft = overDraft;
        }

        public double OverDraft { get => overDraft; }

        public bool Withdraw(double amount)
        {
            if ((Balance + overDraft) < amount)
                return false;
            else
            {
                Balance -= amount;
                return true;
            }
        }

    }
}