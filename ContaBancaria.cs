using System;

namespace PrimeiroProjeto
{
    class ContaBancaria
    {
        public int NumeroDaConta {get; private set;}
        public string Titular { get; private set;}
        public double Saldo { get; private set;}

        public ContaBancaria(int numeroDaConta, string nomeTitular, double saldoInicial)
        {
            NumeroDaConta = numeroDaConta;
            Titular = nomeTitular;
            Saldo = saldoInicial;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
        }
    }
}