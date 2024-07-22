using PrimeiroProjeto.Entities.ExercicioInterface;
using PrimeiroProjeto.Entities.ExercicioInterface.Services;
using PrimeiroProjeto.Entities.Generics;
namespace PrimeiroProjeto
{
    internal class Program

    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>(); //Aqui estou instanciando a classe como int, mas poderia ser qualquer coisa.
            printService.addValue(13);
            Console.WriteLine(printService.first());
            printService.print();

            //Exceção Generics
            List<Product> list = new List<Product>();
            Product televisao = new Product("Televisão", 20.99);
            Product pc = new Product("PC", 300.99);
            Product televisao2 = new Product("Televisão", 20.99);
            list.Add(televisao);
            list.Add(pc);

            CalculationService calculationService= new CalculationService();
            Console.WriteLine(calculationService.Max(list));

            //GetHashCode e Equals
            Console.WriteLine(televisao.Equals(televisao2));
            Console.WriteLine(televisao.GetHashCode());
            Console.WriteLine(televisao2.GetHashCode());
        }
    }
}