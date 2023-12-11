using System;

namespace OMeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inimigo soldado = new Inimigo("Soldado");

            Console.Write($"Nome do inimigo: {soldado.GetNome()}");
            
            Console.Write($"Vida do inimigo: {soldado.GetVida()}");

            soldado.Danificar(70);

            Console.WriteLine($"Vida do inimigo danificado: {soldado.GetVida()}"); */

            int x;
            Inimigo[] nri;
            
            //Inimigo nri2;
            Random ab = new Random();

            Console.WriteLine("Introduza a quantidade de inimigos. ");
            string z = Console.ReadLine();
            Console.WriteLine();
            x = Convert.ToInt32(z);

            nri = new Inimigo[x];
            //nri2 = new Inimigo("A");

            

            for(int i = 0; i < nri.Length; i++)
            {
                string nome;

                Console.WriteLine($"Introduza o nome do inimigo {i}");
                nome = Console.ReadLine();
                Console.WriteLine();

                Inimigo a = new Inimigo(nome);

                nri[i] = a;

                float aux2 = ab.Next(1, 200);

                nri[i].Danificar(aux2);
                Console.WriteLine($"Dano dado ao inimigo {i}: {aux2}");
                Console.WriteLine();
            }
            
            for(int i = 0; i < nri.Length; i++)
            {
                Console.WriteLine($"Nome do inimigo {i}:");
                Console.WriteLine(nri[i].GetNome());
                Console.WriteLine();
                Console.WriteLine($"Escudo do inimigo {i}:");
                Console.WriteLine(nri[i].GetEscudo());
                Console.WriteLine();
                Console.WriteLine($"Vida do inimigo {i}:");
                Console.WriteLine(nri[i].GetVida());
                Console.WriteLine();
            } 

            for(int i = 0; i < nri.Length; i++)
            {
                float aux = ab.Next(1, 100);
                float aux2 = ab.Next(1, 100);

                Console.WriteLine($"Quantidade de escudo abastecido para o inimigo {i} foi: {aux}.");
                nri[i].Abastecer(Abastecimento.Escudo, aux);
                Console.WriteLine();
                Console.WriteLine($"Quantidade de vida abastecida para o inimigo {i} foi: {aux2}.");
                nri[i].Abastecer(Abastecimento.Vida, aux2);
                Console.WriteLine();
            }

            for(int i = 0; i < nri.Length; i++)
            {
                Console.WriteLine($"Escudo do inimigo {i} após abastecimento:");
                Console.WriteLine(nri[i].GetEscudo());
                Console.WriteLine();
                Console.WriteLine($"Vida do inimigo {i} após abastecimento:");
                Console.WriteLine(nri[i].GetVida());
                Console.WriteLine();
            } 



            /*nri2.Danificar(300);
            Console.WriteLine($"Escudo: {nri2.GetEscudo()}");
            Console.WriteLine($"Vida: {nri2.GetVida()}");

            nri2.Abastecer(Abastecimento.Vida, 20);
            Console.WriteLine($"Escudo após abastecimento: {nri2.GetEscudo()}");
            Console.WriteLine($"Vida após abastecimento: {nri2.GetVida()}");

            nri2.Abastecer(Abastecimento.Escudo, 100);
            Console.WriteLine($"Escudo após abastecimento: {nri2.GetEscudo()}");
            Console.WriteLine($"Vida após abastecimento: {nri2.GetVida()}");

            nri2.Abastecer(Abastecimento.Vida, 90);
            Console.WriteLine($"Escudo após abastecimento: {nri2.GetEscudo()}");
            Console.WriteLine($"Vida após abastecimento: {nri2.GetVida()}");*/

            Console.WriteLine("Número total de abastecimentos: ");
            Console.WriteLine(Inimigo.GetValor());
        }
    }
}
