using System;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");

            Escrita(filePath);
        }

        public static void Escrita(string filePath)
        {
            string ss = "String de teste";
            int ii = 12312;
            float rr = 1234f;


            TextWriter tw = File.CreateText(filePath);

            tw.WriteLine(ss);
            tw.WriteLine(ii);
            tw.WriteLine(rr);        
            
            tw.Close();
        }
    }
}
