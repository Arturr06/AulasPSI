using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQLeitor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lerlinhas;
            char delimitador = ' ';
            double mediacarateres;
            bool linha120;  
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "livro.txt");

            lerlinhas = File.ReadAllLines(filePath);

            int nrlinhas = lerlinhas.Count(x => x.Length > 30);

            Console.WriteLine("Número de linhas lidas com mais de 30 caracteres: " + nrlinhas);

            mediacarateres = lerlinhas.Average(x => x.Length);

            Console.WriteLine("Media do número de caracteres das linhas lidas: " + mediacarateres);

            linha120 = lerlinhas.Any(x => x.Length > 120);

            Console.WriteLine("Existe alguma linha com mais que 120 caracteres? " + linha120);

            IEnumerable<string> primeirapalavra = lerlinhas
                .Where(x => x.Contains("Y"))
                .Select(x => x.Split(delimitador)[0]);

            foreach (string ax in primeirapalavra)
            {
                Console.WriteLine(ax);
            }
        }
    }
}
