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
            printService.addValue(1);
            printService.addValue(11);
            printService.addValue(12);
            Console.WriteLine(printService.first());
            printService.print();

            //Exceção Generics
            List<Product> list = new List<Product>();
            list.Add(new Product("Televisão", 20.99));
            list.Add(new Product("PC", 300.99));
            list.Add(new Product("Paçoca", 1.99));

            CalculationService calculationService= new CalculationService();
            Console.WriteLine(calculationService.Max(list));
        }
    }
}