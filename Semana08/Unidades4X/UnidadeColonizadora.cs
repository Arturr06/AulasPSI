using System;

namespace Unidades4X
{
    public class UnidadeColonizadora : Unidade
    {
        public UnidadeColonizadora(int movimento, int vida) : base(movimento, vida)
        {
            
        }
        
        public void Colonizar()
        {
            Console.WriteLine("Territorio colonizado!");
        }
    }
}