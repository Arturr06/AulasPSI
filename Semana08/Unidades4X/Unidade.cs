using System;

namespace Unidades4X
{
    public class Unidade 
    {
      private int movimento;
        public int Vida{get; set;}

       public Unidade(int movimento, int vida) 
       {
          this.movimento = movimento;

          Vida = vida;
       }

      public void Mover(int a)
      {
        Console.WriteLine(a);
      }
    }
}