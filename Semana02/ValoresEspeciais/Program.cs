using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);    
            Console.WriteLine((double)float.MaxValue);
            Console.WriteLine(float.NaN);
            Console.WriteLine(a / 0);
        }
    }
}
