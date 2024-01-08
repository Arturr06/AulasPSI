using System;

namespace TesteErros
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            Console.Write("Insere um número inteiro: ");
            
            try
            {
                i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Número inserido: {i}");
            } 
            catch(FormatException)
            {
                Console.WriteLine("Não foi inserido um numero inteiro.");
            } 
            catch(OverflowException)
            {
                Console.WriteLine("O numero inserido é demasiado grande ou demasiado pequeno.");
            }
            catch(Exception)
            {
                Console.WriteLine("Ocorreu um erro desconhecido.");
            }
            
            
        }
    }
}
