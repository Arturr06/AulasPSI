using System;

namespace Animais
{
    public class Cao : Animal , IMamifero
    {
        public override string Som()
        {
            return base.Som() + "Au Au Au";
        }

        public int NumeroDeMamilos {get{return 8;}}

        
        
    }
}