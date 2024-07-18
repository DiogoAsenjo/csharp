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
            printService.addValue(0);
            printService.addValue(21);
            printService.addValue(99);
            printService.addValue(10);
            printService.addValue(10);
            printService.addValue(10);
            printService.addValue(10);
            printService.addValue(11);
            printService.addValue(12);
            Console.WriteLine(printService.first());
            printService.print();
        }
    }
}