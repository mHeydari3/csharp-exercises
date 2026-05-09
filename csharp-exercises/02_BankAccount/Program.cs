using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises._02_BankAccount
{
    class Program
    {
        static void Main3(string[] args)
        {
            BankAccount alirezaBankAccount = new BankAccount(9, "alireza");

            BankAccount hassanBankAccount = new BankAccount(100, "hassan");

            BankAccount mehranBankAccount = new BankAccount(5, "mehran");

            mehranBankAccount.Deposit(10);

            hassanBankAccount.Withdraw(90);

            alirezaBankAccount.GetInfo();
            hassanBankAccount.GetInfo();
            mehranBankAccount.GetInfo();

            Console.WriteLine("----------------------------------\n\n");
            Console.WriteLine("Total acc created:   " + BankAccount.GetTotalAccounts());

            Console.WriteLine("----------------------------------\n\n");

            List<string> Names = new List<string>();

            Names.Add("Iman");
            Names.Add("Ali");
            Names.Add("Mamadreza");


            foreach (string a_name in Names)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"###--->  {a_name}");
            }

            Console.ReadKey();
        }

    }
}
