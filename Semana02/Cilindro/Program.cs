using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double raio;
            double volume;
            double AreaS;
            double pi = 3.1415926;

            string texto = Console.ReadLine();

            volume = pi * raio * altura;

            AreaS = (2 * pi) * raio * (raio + altura);

        }
    }
}
