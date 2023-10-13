using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Introduza o número de linhas.");
            string nrlinhas = Console.ReadLine();

            y = Convert.ToInt32(nrlinhas);

            for (int i = 1; i <= y; i++)
                {
                        for(int a = 1; a <= y - i; a++){
                            Console.Write(" ");
                        }

                        for(int b = 1; b <= 2 * i - 1; b++){
                            Console.Write("*");
                        }

                    Console.WriteLine();     
                }
        }
    }
}
