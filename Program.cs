using System.IO;
using System.Collections.Generic;  

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Diogo\Desktop\Cursos\.NET\PrimeiroProjeto\Entities\Arquivos\Document.txt";
            string targetPath = @"C:\Users\Diogo\Desktop\Cursos\.NET\PrimeiroProjeto\Entities\Arquivos\Teste.txt";
            string folderPath = @"C:\Users\Diogo\Desktop\Cursos\.NET\PrimeiroProjeto\Entities";
            try
            {
                IEnumerable<String> folders  = Directory.EnumerateDirectories(folderPath, "*.*", SearchOption.AllDirectories);
                
                foreach(string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                string[] lines = File.ReadAllLines(filePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
                catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}