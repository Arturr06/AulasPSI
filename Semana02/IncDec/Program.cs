using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int sufxA = 3;
            int sufxB = 5;
            int c = 0;

            int prefA = 7;
            int prefB = 5;
            int c2 = 0;


            c = sufxA++ + sufxB++;
            c2 = --prefA - --prefB;

            
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(c2);
        }
    }
}
