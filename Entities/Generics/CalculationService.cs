using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Entities.Generics
{
    public class CalculationService
    {
        //Em algumas situações, é possível ter problemas com o Generics, como no caso de comparação, sendo assim, é necessário que o objeto implemente o IComparable, observar como a classe Product é criada.
        public T Max<T>(List<T> list) where T : IComparable 
        {
            if (list.Count ==0) 
            {
                throw new ArgumentException("list should have at least one element");
            }

            T higher = list[0];
            for (int i =0; i < list.Count; i++)
            {
                if (list[i].CompareTo(higher) > 0)
                {
                    higher = list[i];
                }
            }

            return higher;
        }
    }
}