using System;

namespace ValorEReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] {2,4,6,8};
            int[] num2 = nums;
            int a = 5;
            int b = a;


            Metodo(a, nums);

             /*for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            } */

            Console.WriteLine();
            Console.WriteLine(b + 1);

            for(int u = 0; u < num2.Length; u++)
            {
                Console.Write(num2[u] = nums[u] + 1);
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alterado apenas o valor do 2º array: ");
            Console.WriteLine();

            Metodo(a, nums);

            /* for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            } */

            Console.WriteLine();

            Console.WriteLine(b);

            num2 = new int[3] {5, 15, 20};

            for(int u = 0; u < num2.Length; u++)
            {
                Console.Write(num2[u]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Apenas os valores da 1ª variável de cada tipo: ");
            Console.WriteLine();

            Metodo(a, nums);
            
            /* for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            } */
        }

        static void Metodo(int i, int[] n)
        {
            Console.WriteLine(i);

            for(int u = 0; u < n.Length; u++)
            {
                Console.Write(n[u]);
            }
        }
    }
}
