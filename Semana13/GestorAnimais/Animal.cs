using System;


namespace GestorAnimais
{
    public class Animal
    {
        public string Nome{get;}

        public int Peso{get; set;}

        public Animal(string a, int b)
        {
            Nome = a;
            Peso = b;
        }

        public override string ToString()
        {
            return Nome;
        }   

    }
}