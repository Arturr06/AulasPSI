using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura; 
            double raio; 
            
            Console.WriteLine("Insira o valor da altura. ");
            string texto = Console.ReadLine();
            Console.WriteLine("Insira o valor do raio. ");
            string texto2 = Console.ReadLine();

            altura = double.Parse(texto);
            raio = double.Parse(texto2);

            double volume;
            double AreaS;
            //double pi = 3.1415926;
            
            volume = Math.PI * Math.Pow(raio, raio) * altura;

            AreaS = 2 * Math.PI * raio * (raio + altura);

            Console.WriteLine("O valor do volume é: ");
            Console.WriteLine(volume);
            Console.WriteLine();
            Console.WriteLine("O valor da área de superficie: ");
            Console.WriteLine(AreaS);
        }
    }
}
