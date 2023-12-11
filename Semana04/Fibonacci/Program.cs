using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {   
            int nr;
            string nr1;

            if(args.Length > 0)
            {
                nr = Convert.ToInt32(args[0]);
            }else
            {
                Console.WriteLine("Introduza um valor. ");
                
                nr1 = Console.ReadLine();
                nr = Convert.ToInt32(nr1);
            }

            Console.WriteLine("Valor de Fibonacci: ");
            Console.WriteLine();
            Console.WriteLine(Fibonacci(nr));
        }

        private static int Fibonacci(int n)
        {
            int nr;
            
            if(n <= 2)
            {
                nr = 1;
            }else 
            {
                nr = Fibonacci(n - 2) + Fibonacci(n - 1);
            }
            return nr;
        }
    }
}
