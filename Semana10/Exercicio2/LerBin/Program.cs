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

            BinaryReader br = new BinaryReader(File.OpenRead(filePath));


            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadSingle());


            br.Close();


        }
    }
}
