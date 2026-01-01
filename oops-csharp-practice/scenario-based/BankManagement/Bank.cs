using System;

namespace BankSystem

{
    class Bank
    {
        private string[,] accounts = new string[10, 4];
        private int count = 0;

        public void CreateAccount(string accNo, double balance, double minBalance)
        {
            if(FindAccount(accNo) != -1)
            {
                Console.WriteLine("Account already exists");
                return;
            }

            accounts[count, 0] = accNo;
            accounts[count, 1] = balance.ToString();
            accounts[count, 2] = minBalance.ToString();
            accounts[count, 3] = DateTime.Now.ToString("dd-MM-yyyy");

            count++;
            Console.WriteLine("Account created successfully");
        }

        public void ShowAccount(string accNo)
        {
            int i = FindAccount(accNo);
            if(i == -1)
            {
                Console.WriteLine("Account not found");
                return;
            }

            Console.WriteLine("Account No     : " + accounts[i, 0]);
            Console.WriteLine("Balance        : " + accounts[i, 1]);
            Console.WriteLine("Min Balance    : " + accounts[i, 2]);
            Console.WriteLine("Created On     : " + accounts[i, 3]);
        }

        public void Deposit(string accNo, double amt)
        {
            int i = FindAccount(accNo);
            if(i == -1)
            {
                Console.WriteLine("Account not found");
                return;
            }

            double bal = Convert.ToDouble(accounts[i, 1]);
            bal += amt;
            accounts[i, 1] = bal.ToString();

            Console.WriteLine("Deposit successful");
        }

        public void Withdraw(string accNo, double amt)
        {
            int i = FindAccount(accNo);
            if(i == -1)
            {
                Console.WriteLine("Account not found");
                return;
            }

            double bal = Convert.ToDouble(accounts[i, 1]);
            double min = Convert.ToDouble(accounts[i, 2]);

            if(bal - amt < min)
            {
                Console.WriteLine("Minimum balance limit reached");
                return;
            }

            bal -= amt;
            accounts[i, 1] = bal.ToString();
            Console.WriteLine("Withdrawal successful");
        }

        private int FindAccount(string accNo)
        {
            for(int i = 0; i < count; i++)
            {
                if(accounts[i, 0] == accNo)
                    return i;
            }
            return -1;
        }
    }
}
