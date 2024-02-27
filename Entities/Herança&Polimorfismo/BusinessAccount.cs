using System;
using PrimeiroProjeto.Entities;

namespace PrimeiroProjeto
{
    class BusinessAccount : BankAccount
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, string name,  double loanLimit, double? initialDeposit = null) : base(number, name, initialDeposit)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount > LoanLimit)
            {
                Console.WriteLine($"You can't loan {amount}. Your loan limit is ${LoanLimit}");
                return;
            }

            Balance += amount;
        }

        public override string ToString()
        {
            return $"Business Account data. Number: {Number}, Holder: {Holder}, Balance: {Balance}, Loan Limit: {LoanLimit}";
        }
    }
}