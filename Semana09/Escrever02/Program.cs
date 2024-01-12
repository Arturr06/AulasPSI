using System;
using System.IO;

namespace Escrever02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string s;
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");
            StreamWriter dd = new StreamWriter(filePath);


            Console.WriteLine("Escreva o que pretende adicionar ao ficheiro.");
            Console.WriteLine("");

            do
            {
                a = Console.ReadLine();
                
                if(a != "")
                {
                    dd.WriteLine(a);
                }
              
            }while(a != "");            
            
            dd.Close();

            StreamReader ss = new StreamReader(filePath);
            
            do
            {
                s = ss.ReadLine();
                
                Console.WriteLine(s);
            }while(s != null);
            
            ss.Close();
        }
    }
}
