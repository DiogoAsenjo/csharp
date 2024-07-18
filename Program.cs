using PrimeiroProjeto.Entities.ExercicioInterface;
using PrimeiroProjeto.Entities.ExercicioInterface.Services;
using PrimeiroProjeto.Entities.Generics;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();
            printService.addValue(2);
            Console.WriteLine(printService.first());
            printService.print();
        }
    }
}