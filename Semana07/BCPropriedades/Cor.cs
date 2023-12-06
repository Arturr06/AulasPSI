using System;

namespace BCPropriedades
{
    public class Cor
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public int Alpha { get; set; }

        public int GrauDeCinza { get {return  (Red + Green + Blue) / 3;} }

        public Cor(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        
        public Cor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

    }
}