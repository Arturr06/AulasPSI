﻿using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
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

            String.Format("Y = {3}, X = {0}", x, y);

            Console.WriteLine(@"Verbatim com x = {5}", x);


            Console.WriteLine(aspas2);

            Console.WriteLine(aspas);

            Console.WriteLine(nome);

            Console.WriteLine(pasta);

            Console.WriteLine(pasta2);

            Console.WriteLine(melhor);

            Console.WriteLine(contaInt);

            Console.WriteLine(contaInt2);
        }
    }
}
