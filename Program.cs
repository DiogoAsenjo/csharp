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
            BankAccount bankAcc = new BankAccount(1, "Diogo");
            BusinessAccount busAcc = new BusinessAccount(1, "ModalGR", 500.00);

            //UPCASTING. Como BusinessAccount é classe mãe, as linhas abaixo sãp possíveis.
            BankAccount teste = busAcc;
            BankAccount teste2 = new BusinessAccount(2, "Paiol", 100.00);

            //DOWNCASTING. Cuidado com isso, tem que ser instancia com o tipo que vai virar.
            BusinessAccount teste3 = teste2 as BusinessAccount;
            Console.WriteLine(teste3);
        }
    }
}