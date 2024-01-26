using System;

namespace OMeuJogoMVC
{
    class View
    {
        private Controller abc;

        public View(Controller ffa)
        {
            abc = ffa;
        }

            public string F1nome(int i)
            {
                string nome;

                Console.WriteLine($"Introduza o nome do inimigo {i}");
                nome = Console.ReadLine();
                Console.WriteLine();

                return nome;       
            }

            public void MostrarDano(int i, float aux2)
            {   
                Console.WriteLine($"Dano dado ao inimigo {i}: {aux2}");
                Console.WriteLine();
            }

            public void Info(int i, Inimigo[] nri)
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

            public void Abastecer(int i, float aux, float aux2, Inimigo[] nri)
            {
                Console.WriteLine($"Quantidade de escudo abastecido para o inimigo {i} foi: {aux}.");
                nri[i].Abastecer(Abastecimento.Escudo, aux);
                Console.WriteLine();
                Console.WriteLine($"Quantidade de vida abastecida para o inimigo {i} foi: {aux2}.");
                nri[i].Abastecer(Abastecimento.Vida, aux2);
                Console.WriteLine();                
            }

            public string Pedir()
            {
                Console.WriteLine("Introduza a quantidade de inimigos. ");
                string z = Console.ReadLine();
                Console.WriteLine();

                return z;
            }

            public void Infoab(int i, Inimigo[] nri)
            {
                Console.WriteLine($"Escudo do inimigo {i} após abastecimento:");
                Console.WriteLine(nri[i].GetEscudo());
                Console.WriteLine();
                Console.WriteLine($"Vida do inimigo {i} após abastecimento:");
                Console.WriteLine(nri[i].GetVida());
                Console.WriteLine();
            }
    }
}