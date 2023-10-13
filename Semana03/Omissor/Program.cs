using System;

namespace Omissor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa deve solicitar uma string ao utilizador
            Console.WriteLine("Insira uma frase.");

            string frase = Console.ReadLine();

            //Seguidamente, deve solicitar um caráter ao utilizador
            Console.WriteLine("Insira um carater que quer que seja removido da frase.");

            string caraterint = Console.ReadLine();

            char carater = caraterint[0]; 

            //Por fim, deve imprimir a string omitindo o caráter

            foreach (char c in frase) {

                if(c != carater)
                {
                    Console.Write(c);
                }
            }
                
               

            
        }
    }
}
