using System;

namespace Animais
{
    public class Gato : Animal , IMamifero
    {
        public override string Som()
        {
            return base.Som() + "Miau";
        }

        public int NumeroDeMamilos {get{return 8;}}
    }
}