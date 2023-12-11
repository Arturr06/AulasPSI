using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //A partir do comando new Stopwatch são criadas as instâncias
            //Sim porque é independente
            //Stopwatch consiste na medição com precisão o tempo decorrido
            //Sim é possivel alterar
            //É possivel alterar ao começar e parar o programa extendendo assim o tempo do programa



            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();
            

            cron1.Start();
            Thread.Sleep(1000);
            cron2.Start();
            Thread.Sleep(1000);

            cron1.Stop();
            cron2.Stop();

            Console.WriteLine(cron1.ElapsedMilliseconds);
            Console.WriteLine(cron2.ElapsedMilliseconds);
        }
    }
}
