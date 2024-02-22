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
            User diogo = new User(1, "Diogo");
            User lorena = new User(2, "Lorena");
            User ryan = new User(3, "Ryan");
            User neemias = new User(4, "Neemias");

            Account conta1 = new Account(1, diogo, lorena);
            Account conta2 = new Account(2, ryan, neemias);

            Transaction t1 = new Transaction(1, 10.00, diogo, conta1);
            Transaction t2 = new Transaction(2, 20.00, lorena, conta1);
            Transaction t3 = new Transaction(3, 50.00, diogo, conta1);

            Transaction t1c2 = new Transaction(1, 40.00, ryan, conta2);
            Transaction t2c2 = new Transaction(2, 10.00, neemias, conta2);
            Transaction t3c2 = new Transaction(3, 30.00, neemias, conta2);

            Console.WriteLine(conta2.seeingWhoOwnsWho());
        }
    }
}