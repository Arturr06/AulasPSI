using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro");
            string num1 = Console.ReadLine();
            Console.WriteLine("Insira outro numero inteiro");
            string num2 = Console.ReadLine();
            int n1, n2, n3;

            n1 = Convert.ToInt32(num1);
            n2 = Convert.ToInt32(num2);

            n3 = n1 * n2;

            

            Console.WriteLine(n3);

            if (n3 % 3 == 0)
        {
            Console.WriteLine("Múltiplo de 3!");
        }
        }
    }
}
