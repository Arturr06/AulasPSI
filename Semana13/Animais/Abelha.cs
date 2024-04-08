using System;


namespace Animais
{
    public class Abelha : Animal , IVoador
    {
        public override string Som()
        {
            return base.Som() + "Bzzz";
        }

        public int NumeroDeAsas {get{return 2;}}
    }
}