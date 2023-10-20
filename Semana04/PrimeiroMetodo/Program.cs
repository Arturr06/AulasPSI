using System;

namespace Primeiro_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
           //ContarAte10();
           //Console.WriteLine();
           ContarAte10();

           Console.WriteLine();

            int N;          
           Console.WriteLine("Introduza o número. ");
           string Nr = Console.ReadLine();

           N = Convert.ToInt32(Nr);

           ContarAteN(N);

           Console.WriteLine();
          
           Console.WriteLine("Introduza o número. ");
           Nr = Console.ReadLine();

           N = Convert.ToInt32(Nr);

           ContarAteN(N); 
        }

        private static void ContarAte10()
        {
            ContarAteN(10);
        }

        private static void ContarAteN(int N)
        {

            for(int o = 1; o <= N; o++)
            {
                Console.WriteLine(o);
            }
        }
    }
}
