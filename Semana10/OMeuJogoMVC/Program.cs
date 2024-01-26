using System;

namespace OMeuJogoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimigo[] nri = new Inimigo[0];

            Controller controller = new Controller(nri);

            View view = new View(controller);

            controller.IniciarPrograma(view);
        }
    }
}
