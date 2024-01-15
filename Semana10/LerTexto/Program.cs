using System;
using System.IO;

namespace LerTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");

            TextReader tr = File.OpenText(filePath);


            Console.WriteLine(tr.ReadLine());
            Console.WriteLine(tr.ReadLine());
            Console.WriteLine(tr.ReadLine());


            tr.Close();
        }
    }
}
