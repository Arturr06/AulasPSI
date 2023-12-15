using System;

namespace Unidades4X
{
    public class UnidadeColonizadora : Unidade
    {
        public override float Valor{get{return 5;}}
        
        public UnidadeColonizadora(int movimento, int vida) : base(movimento, vida)
        {
            
        }
        
        public void Colonizar()
        {
            Console.WriteLine("Territorio colonizado!");
        }
    }
}