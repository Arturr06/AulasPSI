using System;

namespace TipoVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 5;
            long valor2 = 2000000;
            short valor3 = 1;

            Console.WriteLine(valor1, valor2, valor3);

            double real1 = 3.422;
            decimal real2 = 15.322;
            float real3 = 12.512f;

            Console.WriteLine(real1, real2, real3);

             char simboloCopyright = '\u00A9';
             char heart = '\u2665';

            Console.WriteLine(simboloCopyright, heart);

            bool b = true;
            bool c = 4 > 5;

            Console.WriteLine(b, c);
         

        }
    }
}
