using System;

namespace BankSystem
{
    class User
    {
        public int UserId { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }   // Admin / Customer
        public string AccountNo { get; private set; }

        public User(int id, string name, string role)
        {
            UserId = id;
            Name = name;
            Role = role;
            AccountNo = "";
        }

        public bool HasAccount
        {
            get { return AccountNo != ""; }
        }

        public void AssignAccount(string accNo)
        {
            AccountNo = accNo;
        }

        public void ShowUser()
        {
            Console.WriteLine("User Id  : " + UserId);
            Console.WriteLine("Name     : " + Name);
            Console.WriteLine("Role     : " + Role);
            Console.WriteLine("Account  : " +(HasAccount ? AccountNo : "Not Created"));
        }
    }
}
