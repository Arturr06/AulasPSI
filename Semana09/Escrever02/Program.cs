using System;
using System.IO;

namespace Escrever02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[1000];
            int b = 0;
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");
            StreamWriter dd = new StreamWriter(filePath);


            Console.WriteLine("Escreva o que pretende adicionar ao ficheiro.");
            Console.WriteLine("");

            do
            {
                a[b] = Console.ReadLine();

                if(a[b] != "")
                {
                    dd.WriteLine(a[b]);
                }
                
                b++;
              
            }while(a[b - 1] != "");            
            
            dd.Close();
        }
    }
}
