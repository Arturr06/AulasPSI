using System;

namespace Unidades4X
{
    public abstract class Unidade 
    {
        private int movimento;
        public virtual int Vida{get; set;}

        public abstract float Valor{get;}

       public Unidade(int movimento, int vida) 
       {
          this.movimento = movimento;

          Vida = vida;
       }

      public int Mover(int a)
      {
        return a;
      }

      public override string ToString()
      {
          return $"\n Vida: {Vida}" + $"\n Valor: {Valor} \n";
      }
    }
}