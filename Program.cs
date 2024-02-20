using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VETOR NORMAL
            double[] vetor = new double[4];
            
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(vetor.ToString());


            //VETOR DE CLASSES
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

            //VETOR COMO PARÂMETRO - PARAMS
            double total = Somador.SomaTudo(1.00, 9.47, 0.11, 2.53);
            Console.WriteLine(total);

            //LISTA
            List<string> listaDeNomes = new List<string>{"Diogo", "Neemias", "Ryan", "Diego"};

            listaDeNomes.Add("Russio");

            Console.WriteLine(listaDeNomes.Last());

            List<string> nomesComD = listaDeNomes.FindAll(nome => nome[0] == 'D');

            foreach (string nome in nomesComD)
            {
                Console.WriteLine(nome);
            }
        }
    }
}