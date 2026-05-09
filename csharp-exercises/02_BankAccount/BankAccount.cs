using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises._02_BankAccount
{
    class BankAccount
    {
        private static int MinimumAllowedBalance = 5;  // default limit balance, set by the Bank
        private static int TotalAccountsCreated = 0;
        private string _account_number;
        private string _owner_name;
        public string AccountNumber
        {
            get;
            private set;

        }

        public string OwnerName
        {
            get { return _owner_name; }
            set
            {


                if (value == null || value == "" || value == " " || value.Length < 3)
                {
                    throw new ArgumentException();
                }
                _owner_name = value;
            }

        }

        public decimal Balance
        {
            get; private set;
        }





        public BankAccount(decimal initialBalance, string ownerName)
        {
            Random rnd = new Random();
            int rnd_num = rnd.Next(1, 9);

            this._account_number = "ACC-" + rnd_num;


            this.Balance = initialBalance;
            this.OwnerName = ownerName;


            if (this.Balance < BankAccount.MinimumAllowedBalance)
            {
                throw new ArgumentException();
            }
            TotalAccountsCreated++;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();
            }
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if ((amount <= 0) || (this.Balance - amount <= 0) || (this.Balance - amount <= MinimumAllowedBalance))
            {
                throw new ArgumentException();
            }

            this.Balance -= amount;

        }

        public void GetInfo()
        {
            string output = "";
            output += $"Account Number: {this.AccountNumber}";
            output += $"   |   Account Owner: {this.OwnerName}";
            output += $"   |   Account Balance: {this.Balance}";

            Console.WriteLine(output);

        }


        public static int GetTotalAccounts()
        {
            return TotalAccountsCreated;
        }
    }

}
