using System;
using System.IO;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            EscreverTexto et = new EscreverTexto();
            
            string escolha;
            const string opA = "1", opB = "2", opC = "3", opD = "4", opFinal = "exit";

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt");

            do
            {
                Console.WriteLine("Se quiseres escrever texto clica (1) se quiseres ler texto clica (2). Se quiseres escrever binário clica (3) se quiseres ler binário clica (4).");

                Console.WriteLine("");

                Console.WriteLine("Se quiseres fechar o programa escreve exit.");

                escolha = Console.ReadLine();
                
                
                if(escolha == opA)
                {
                    et.Escrita(filePath);
                } 




            } while(escolha != opFinal);
        }
    }
}