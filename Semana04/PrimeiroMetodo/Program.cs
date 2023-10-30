using System;

namespace Primeiro_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
           //ContarAte10();
           //Console.WriteLine();
           //ContarAte10();

           Console.WriteLine();

            int n1, n2;          
           Console.WriteLine("Introduza o número. ");
           string Nr1 = Console.ReadLine();

           n1 = Convert.ToInt32(Nr1);

           ContarAteN(n1);
         
           Console.WriteLine("Introduza um número. ");
           Nr1 = Console.ReadLine();
           Console.WriteLine("Introduza outro número. ");
           string Nr2 = Console.ReadLine();

           n1 = Convert.ToInt32(Nr1);
           n2 = Convert.ToInt32(Nr2);

           ContarAteN(n1, n2); 
        }

        /*private static void ContarAte10()
        {
            ContarAteN(10);
        }*/

        private static void ContarAteN(int n1)
        {

            for(int o = 1; o <= n1; o++)
            {
                Console.WriteLine(o);
            }
        }

        private static void ContarAteN(int n1, int n2)
        {

            if(n2 > n1)
            {
                for(int y = n1; y <= n2 ; y++)
                {
                    Console.WriteLine(y);
                }
            }else 
            {
                for(int y = n1; y >= n2; y--)
                {
                    Console.WriteLine(y);
                }
            }
        }
    }
}
