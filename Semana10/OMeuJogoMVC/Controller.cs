using System;

namespace OMeuJogoMVC
{
    class Controller
    {
        private string nome;

        
        public Controller(Inimigo[] inim)
        {
            nri = inim;
        }
        
        Inimigo[] nri;

        public void IniciarPrograma(View view)
        {
            int x;

            Random ab = new Random();

            x = Convert.ToInt32(view.Pedir());

            nri = new Inimigo[x];


            for(int i = 0; i < nri.Length; i++)
            {
                nome = view.F1nome(i);

                Inimigo a = new Inimigo(nome);
                
                nri[i] = a;

                float aux2 = ab.Next(1, 200);

                nri[i].Danificar(aux2);
                
                view.MostrarDano(i, aux2);
            }
                       
            for(int i = 0; i < nri.Length; i++)
            {
                view.Info(i, nri);
            }

            for(int i = 0; i < nri.Length; i++)
            {
                float aux = ab.Next(1, 100);
                float aux2 = ab.Next(1, 100);

                view.Abastecer(i, aux, aux2, nri);
            }

            for(int i = 0; i < nri.Length; i++)
            {
                view.Infoab(i, nri);
            }
        }
    }
}