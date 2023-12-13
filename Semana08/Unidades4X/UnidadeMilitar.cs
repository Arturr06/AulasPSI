using System;

namespace Unidades4X
{
    public class UnidadeMilitar : Unidade
    {
        public int PoderAtaque {get; set;}
        public int XP {get; set;}

        public void Atacar(UnidadeMilitar um, int dano)
        {
            Console.WriteLine($"A unidade militar {um} foi danificada com {dano} dano.");
        }
    }
}