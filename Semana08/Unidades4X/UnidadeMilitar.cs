using System;

namespace Unidades4X
{
    public class UnidadeMilitar : Unidade
    {
        public int PoderAtaque {get; set;}
        public int XP {get; set;}

        public UnidadeMilitar(int movimento, int vida, int poderAtaque) : base(movimento, vida)
        {
            PoderAtaque = poderAtaque;
            XP = 0;
        }

        public void Atacar(UnidadeMilitar um, int dano)
        {
            Console.WriteLine($"A unidade militar {um} foi danificada com {dano} dano.");
        }
    }
}