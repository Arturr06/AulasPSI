using System;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.bin");

            string ss = "String de teste 2";
            int ii = 52512;
            float rr = 09582f;


            BinaryWriter bw = new BinaryWriter(File.Create(filePath));

            bw.Write(ss);
            Console.WriteLine(ss);
            bw.Write(ii);
            Console.WriteLine(ii);
            bw.Write(rr);
            Console.WriteLine(rr);

            bw.Close();
        }
    }
}