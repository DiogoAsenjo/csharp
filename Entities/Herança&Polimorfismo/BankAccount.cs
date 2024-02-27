using System;

namespace PrimeiroProjeto
{
    class BankAccount
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public BankAccount()
        {
        }

        public BankAccount(int number, string name, double? initialDeposit = null)
        {
            Number = number;
            Holder = name;
            Balance = initialDeposit ?? 0.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine($"You can only withdraw up until ${Balance}");
            } else 
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account data. Number: {Number}, Holder: {Holder}, Balance: {Balance}";
        }
    }
}