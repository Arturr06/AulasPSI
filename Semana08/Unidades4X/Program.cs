using System;

namespace Unidades4X
{
    class Program
    {
        static void Main(string[] args)
        {
            Unidade c1 = new UnidadeColonizadora(2, 76);
            Unidade c2 = new UnidadeColonizadora(3, 87);

            Unidade m1 = new UnidadeMilitar(2, 48, 35);
            Unidade m2 = new UnidadeMilitar(3, 73, 60);

            Console.WriteLine($"Primeira unidade Colonizadora avançou {c1.Mover(4)} territorios. ");
            Console.WriteLine(" ");
            Console.WriteLine($"A segunda unidade Colonizadora avançou {c2.Mover(5)} territorios. ");
            Console.WriteLine(" ");
            Console.WriteLine($"Primeira unidade Militar avançou {m1.Mover(2)} territorios. ");
            Console.WriteLine(" ");
            Console.WriteLine($"A segunda unidade Militar avançou {m2.Mover(7)} territorios.");

            Console.WriteLine(" ");

            Console.WriteLine($"Primeira unidade Colonizadora \n {c1}");

            Console.WriteLine($"Segunda unidade Colonizadora \n {c2}");

            Console.WriteLine($"Primeira unidade Militar \n {m1}");

            Console.WriteLine($"Segunda unidade Militar \n {m2}");
            
        }
    }
}
