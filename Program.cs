using System;
using System.ComponentModel;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[4];
            
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(vetor.ToString());

            Produto[] vetorProdutos = new Produto[3];

            vetorProdutos[0] = new Produto("TV", 900.00, 1);
            vetorProdutos[1] = new Produto("Frigideira", 400.00, 1);
            vetorProdutos[2] = new Produto("Stove", 800.00, 1);

            double sum = 0.00;
            for (int i = 0; i < vetorProdutos.Length; i++)
            {
                sum += vetorProdutos[i].Preco;
            }

            double media = sum / 3;

            Console.WriteLine(media);
        }
    }
}