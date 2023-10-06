using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 5;
            int c = 15;
            float f1, f2;

            f1 = f2 = 13200.0f;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);    
            Console.WriteLine((double)float.MaxValue);
            Console.WriteLine(float.NaN);
            Console.WriteLine((double) (b + 1));
            Console.WriteLine((short) (c - 1));
            Console.WriteLine(2 * double.MaxValue);
            Console.WriteLine(float.MinValue / 2);
            Console.WriteLine(f1 == f2 + 0.00001f); 
        }
    }
}
