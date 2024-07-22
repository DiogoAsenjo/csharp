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
            Product tablet = new Product("Tablet", 21.99);
            list.Add(televisao);
            list.Add(pc);

            CalculationService calculationService= new CalculationService();
            Console.WriteLine(calculationService.Max(list));

            //GetHashCode e Equals
            Console.WriteLine(televisao.Equals(tablet));
            Console.WriteLine(televisao.GetHashCode());
            Console.WriteLine(tablet.GetHashCode());

            //HashSet e SortedSet são estruturas de dados do C#
            HashSet<Product> set = new HashSet<Product>();
            set.Add(televisao);
            set.Add(pc);

            HashSet<Product> set2 = new HashSet<Product>();
            set2.Add(televisao);

            HashSet<Product> set3 = new HashSet<Product>();
            set3.UnionWith(set);
            set3.IntersectWith(set2);

            //Console.WriteLine(set.Contains(televisao));

            foreach(Product p in set3)
            {
                Console.WriteLine(p);
            }

            //Dictionary 
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies.Add("user", "Diogo");
            cookies.Add("password", "123456");
            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}