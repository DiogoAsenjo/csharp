using System;
using PrimeiroProjeto.Entities;

namespace PrimeiroProjeto
{
    class SavingAccount : BankAccount
    {
       public double InterestRate;

       public SavingAccount(int number, string name, double rate, double? initialDeposit = null) : base(number, name, initialDeposit)
       {    
            InterestRate = rate;
       }

       public void UpdateBalance()
       {
            double income = Balance * InterestRate;
            Balance += income;
       }

        //Override = está sobrepondo o método do classe mãe
        //Sealde = serve apenas para métodos sobrepostos para evitar que haja sobreposição do método já sobreposto.
        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Saving Account data. Number: {Number}, Holder: {Holder}, Balance: {Balance}";
        }
    }
}