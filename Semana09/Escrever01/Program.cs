using System;
using System.IO;

namespace Escrever01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[1000];
            int b = 0;

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");

            Console.WriteLine("Escreva o que pretende adicionar ao ficheiro.");
            Console.WriteLine("");

            do
            {
                a[b] = Console.ReadLine();

                b++;
            }while(a[b - 1] != "");

            File.WriteAllLines(filePath, a);
            

        }
    }
}
