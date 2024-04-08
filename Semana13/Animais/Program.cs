using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] a = new Animal[10];

            
            Random b = new Random();


            


            for(int i = 0; i < 10; i++)
            {   

                a[i] = DefinirAnimal(b.Next(1, 5));

                Console.WriteLine(a[i].Som());
                
                if(a[i] is IMamifero)
                {
                    Console.WriteLine($"O animal tem: {((IMamifero) a[i]).NumeroDeMamilos} mamilos.");
                }

                if(a[i] is IVoador)
                {
                    Console.WriteLine($"O animal tem: {((IVoador) a[i]).NumeroDeAsas} asas.");
                }
                
            }
            

        }

        static Animal DefinirAnimal(int a)
        {            
            
            if(a == 1)
            {
                return new Cao();
            }else if(a == 2)
            {
                return new Gato();
            }else if(a == 3)
            {
                return new Morcego();
            }else if(a == 4)
            {
                return new Abelha();
            }

            

            return new Gato();
        }
    }
}
