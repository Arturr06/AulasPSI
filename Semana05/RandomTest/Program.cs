using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um numero de 1 a 6)");
            
            string n1 = Console.ReadLine();
            int n;
            int soma = 0;    

            n = Convert.ToInt32(n1);

            Random r = new Random();

            for(int i = 0; i <= n; i++)
            {
                soma += r.Next(1, 6);

                Console.WriteLine(soma);
            }

            Console.WriteLine(soma);
        }
    }
}
