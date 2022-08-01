using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace ICICI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "Shreyas", 900000);
            account.Deposit(1000);
            account.Withdraw(100000);
            Console.WriteLine(account.Balance);

            SavingsAccount savingAccount = new SavingsAccount(2, "Tejas", 100000);
            savingAccount.Deposit(100000);
            savingAccount.Withdraw(10000);
            Console.WriteLine(savingAccount.Balance);

            CurrentAccount currentAccount = new CurrentAccount(3, "Sejal", 100000);
            currentAccount.Deposit(100000);
            currentAccount.Withdraw(620000);
            Console.WriteLine(currentAccount.Balance);
        }
    }
}