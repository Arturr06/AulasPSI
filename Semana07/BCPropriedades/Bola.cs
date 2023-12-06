using System;

namespace BCPropriedades
{
    public class Bola
    {
        private Cor cor;
        
        public Cor Cor { get{return cor;} private set{cor = value;}}
        public float Raio { get; set; }
        public int NVezes { get; set; }

        public Bola(float raio, Cor cor)
        {
            Cor = cor;
            Raio = raio;
            NVezes = 0;
        }

        public void Pop()
        {
            Raio = 0;
        }

        public void Atirar()
        {
            if(Raio > 0) NVezes++;
        }
    }
}