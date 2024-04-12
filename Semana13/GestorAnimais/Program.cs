using System;
using System.Collections.Generic;

namespace GestorAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();
            string nome, b, pesominimostring, perguntapesominimo;
            int peso, pesominimoint;

            animais.Insert(0, new Animal("Macaco", 50));
            animais.Insert(1, new Animal("Gorila", 100));

            

            do{
                
                Console.WriteLine("Insira o nome do animal.");

                nome = Console.ReadLine();

                if(nome != "Mostrar")
                {
                    Console.WriteLine("Insira o peso do animal.");

                b = Console.ReadLine();

                peso = Convert.ToInt32(b);

                Animal ab = new Animal(nome , peso);
                
                animais.Add(ab);

                
                }
                
            }while(nome != "Mostrar");
            
            Console.WriteLine("Vai querer listar os animais pelo peso minimo?");

            perguntapesominimo = Console.ReadLine();

           

            if(perguntapesominimo == "Sim")
            {
                
                Console.WriteLine("Qual o peso minimo?");
                pesominimostring = Console.ReadLine();
                pesominimoint = Convert.ToInt32(pesominimostring);


                List<Animal> listaanimaiscompesomaiorque = GetAnimaisComPesoMaiorQue(animais, pesominimoint);

                foreach(Animal ax in listaanimaiscompesomaiorque)
                {
                    Console.WriteLine($"Nome do animal: {ax}");
                    Console.WriteLine($"Peso do animal: {ax.Peso}");
                    Console.WriteLine("");
                }

            }else if(perguntapesominimo == "Nao")
            {
                
                foreach(Animal ax in animais)
            {
                Console.WriteLine($"Nome do animal: {ax}");
                Console.WriteLine($"Peso do animal: {ax.Peso}");
                Console.WriteLine("");
            }
            }
        }

        public static List<Animal> GetAnimaisComPesoMaiorQue(List<Animal> a, int pesominimoint)
        {
            List<Animal> Pesominimo = new List<Animal>();

            foreach(Animal l in a)
            {
                if(l.Peso > pesominimoint)
                {
                    Pesominimo.Add(l);
                }
            }            
            
            return Pesominimo;
        }
    }
}
