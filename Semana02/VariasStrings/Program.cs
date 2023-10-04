using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double dd = 0.12345;
            int ii = 18;
            int x = 0, y = 0;
            char a = 'a', b = 'b';
            
            
            string nome = "Artur \u00A9";
            
            string pasta = "C:\\Users\\nome\\Documents";
            
            string pasta2 = @"C:\Users\nome\Documents";
            
            string melhor = "\t Ronaldo \u0031";

            string aspas = "\"Esta string está entre aspas\"";

            string aspas2 = @"""Esta string também está em aspas""";

            string contaCon = "a" + 2;

            string contaCon2 = "b" + "x";

            string contaInt = $"x = {x}";

            string contaInt2 = $"{x} mais {y} é igual a {x + y}";

            String.Format("Y = {1}, X = {0}", x, y);

            Console.WriteLine(@"Verbatim com x = {0}", x);

            Console.WriteLine();
            Console.WriteLine(aspas2);
            Console.WriteLine();
            Console.WriteLine(aspas);
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine();
            Console.WriteLine(pasta);
            Console.WriteLine();
            Console.WriteLine(pasta2);
            Console.WriteLine();
            Console.WriteLine(melhor);
            Console.WriteLine();
            Console.WriteLine(contaInt);
            Console.WriteLine();
            Console.WriteLine(contaInt2);
            Console.WriteLine();
            Console.WriteLine(contaCon);
            Console.WriteLine();
            Console.WriteLine(contaCon2);

            Console.WriteLine($"{dd:f2}");
            Console.WriteLine($"{dd:p1}");
            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");


        }
    }
}
