using System;

namespace Animais
{
    public class Morcego : Animal , IMamifero , IVoador
    {
        public override string Som()
        {
            return base.Som() + "Ti Ti Ti";
        }

        public int NumeroDeMamilos {get{return 2;}}

        public int NumeroDeAsas {get{return 2;}}
    }
}