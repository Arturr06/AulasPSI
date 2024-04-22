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

            int nrlinhas = 
                (from x in lerlinhas
                where x.Length > 30
                select x).Count();

            Console.WriteLine("Número de linhas lidas com mais de 30 caracteres: " + nrlinhas);

            mediacarateres = 
                (from x in lerlinhas
                select x.Length).Average();

            Console.WriteLine("Media do número de caracteres das linhas lidas: " + mediacarateres);

            linha120 = 
                (from x in lerlinhas
                where x.Length > 120
                select x).Any();

            Console.WriteLine("Existe alguma linha com mais que 120 caracteres? " + linha120);

            /*
            IEnumerable<string> primeirapalavra = 
                from x in lerlinhas
                where x.Contains("Y")
                select x.Split(delimitador)[0];

            foreach (string ax in primeirapalavra)
            {
                Console.WriteLine(ax);
            } */

            

            IEnumerable<string> primeirapalavra = 
                from x in lerlinhas
                where !string.IsNullOrEmpty(x) && x[0] == 'T'
                select x.Split(delimitador)[0];

            foreach (string ax2 in primeirapalavra)
            {
                Console.WriteLine(ax2);
            }    
        }
    }
}
