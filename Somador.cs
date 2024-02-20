using System;

namespace PrimeiroProjeto
{
    class Somador
    {
        public static double SomaTudo(params double[] numbers)
        {
            double somaTotal = 0.00;
            for (int i = 0; i < numbers.Length; i++)
            {
                somaTotal += numbers[i];
            }
            return somaTotal;
        }
    }
}