using System;
using System.IO;
using System.Collections.Generic;

namespace Escrever01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> texto = new List<string>();
            //string[] a = new string[1000];
            int b = 0;

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");

            Console.WriteLine("Escreva o que pretende adicionar ao ficheiro.");
            Console.WriteLine("");

            do
            {
                texto.Add(Console.ReadLine());

                b++;
            }while(texto[b - 1] != "");

            
            File.WriteAllLines(filePath, texto);
        }
    }
}
