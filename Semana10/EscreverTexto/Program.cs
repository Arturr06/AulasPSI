using System;
using System.IO;

namespace EscreverTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");

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
