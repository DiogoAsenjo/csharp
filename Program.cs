using System;
using System.ComponentModel;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount busAcc = new BusinessAccount(1, "ModalGR", 500.00);

            //UPCASTING. Como BusinessAccount é classe mãe, as linhas abaixo sãp possíveis.
            BankAccount upcasting1 = busAcc;
            BankAccount upcasting2 = new BusinessAccount(2, "Paiol", 100.00);

            //DOWNCASTING. Cuidado com isso, tem que ser instancia com o tipo que vai virar.
            BusinessAccount downcasting = upcasting2 as BusinessAccount;
            //Console.WriteLine(downcasting);

            //Sobreposição de método e polimorfismo
            BankAccount bankAcc = new BankAccount(1, "Diogo", 100.00);
            BankAccount savAcc = new SavingAccount(1, "Diogo", 0.20, 100.00);
            bankAcc.Withdraw(10.00);
            //Console.WriteLine(bankAcc);
            savAcc.Withdraw(10.00);
            //Console.WriteLine(savAcc);

            //Exercício polimorfismo
            Employee diogo = new Employee("Diogo", 10, 2.00);
            Employee ellen = new OutsourceEmployee("Ellen", 10, 2.00, 10);
            Console.WriteLine(diogo.Payment());
            Console.WriteLine(ellen.Payment());
        }
    }
}