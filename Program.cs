using System;
using System.ComponentModel;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto caneta = new Produto("Caneta", 2.50, 10);

            ContaBancaria contaDiogo = new ContaBancaria(1, "Diogo Asenjo", 200.00);

            Console.WriteLine(contaDiogo.Saldo);

            contaDiogo.Deposito(100.00);

            Console.WriteLine(contaDiogo.Saldo);

            contaDiogo.Saque(50.00);

            Console.WriteLine(contaDiogo.Saldo);
        }
    }
}