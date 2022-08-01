using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace Axis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account(1, "Soham", 90000);
            //account.Deposit(100);
            //account.Withdraw(5000);
            //Console.WriteLine(account.Balance);

            //SavingsAccount savingAccount = new SavingsAccount(2, "Tejas", 100000, 10000);
            //savingAccount.Deposit(100000);
            //savingAccount.Withdraw(10000);
            //Console.WriteLine(savingAccount.Balance);

            CurrentAccount currentAccount = new CurrentAccount(3, "Soham", 100, 100);
            currentAccount.Deposit(100000);
            currentAccount.Withdraw(620000);
            Console.WriteLine(currentAccount.Balance);
        }
    }
}