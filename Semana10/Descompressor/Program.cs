using System;
using System.IO;
using System.IO.Compression;

namespace Descompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            bool g = false;

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt.gz");
            string filePath2 = Path.Combine(desktop, "File.txt");

            do 
            {

                Console.WriteLine("Deseja comprimir ou descomprimir o ficheiro? (1 comprimir/ 2 descomprimir)");
                
                opcao = Console.ReadLine();

                if(opcao == "1")
                {
                    g = true;
                    Comprime(filePath);

                } else if(opcao == "2")
                {
                    g = true;
                    Descomprime(filePath, filePath2);

                } else
                {
                    Console.WriteLine("Escolha invalida.");
                }

            }while(!g);
        }

        static void Comprime(string filePath)
        {
            string line;

            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

            StreamWriter sw = new StreamWriter(gzs);

            while ((line = Console.ReadLine()).Length > 0)
            {
                sw.WriteLine(line);
            }

            sw.Close();

        }

        static void Descomprime(string filePath, string filePath2)
        {
            string line;

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);

            StreamReader sr = new StreamReader(gzs);

            StreamWriter sw = new StreamWriter(filePath2);

            while ((line = sr.ReadLine()) != null)
            {

               Console.WriteLine(line);
               sw.WriteLine(line);
               
            }

            sr.Close();
            sw.Close();

        }
    }
}