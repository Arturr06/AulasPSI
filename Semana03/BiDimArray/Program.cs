using System;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] dimensao;
            float[] medias;
            int h, v, auxiliar;

            Console.WriteLine("Introduza o valor da dimensão horizontal: ");
            string horizontal = Console.ReadLine();
            Console.WriteLine("Introduza o valor da dimensão vertical: ");
            string vertical = Console.ReadLine();
            
            float media = 0;
            float somamedia = 0;

            h = Convert.ToInt32(horizontal);
            v = Convert.ToInt32(vertical);

            dimensao = new float[v,h];
            medias = new float[h];

            for(int i = 0; i < dimensao.GetLength(0); i++)
            {
                for(int j = 0; j < dimensao.GetLength(1); j++){
                    
                    string g;

                    g = Console.ReadLine();

                    float f = float.Parse(g);

                    dimensao[i,j] = f;
                    
                    media += f;
                }
                Console.WriteLine();

                media /= h;

                medias[i] = media;

                media = 0;

                Console.WriteLine("Media: ");

                Console.WriteLine(medias[i]);

                Console.WriteLine();
            }
            
            Console.WriteLine("Soma das medias: ");
            
            for(int i = 0; i < medias.Length; i++)
            {

                somamedia += medias[i];
            }

            Console.WriteLine(somamedia);
        }
    }
}
