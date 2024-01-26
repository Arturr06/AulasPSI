using System;


namespace OMeuJogoMVC
{
    public class Inimigo
    {
        
        private string nome;
        private float vida;
        private float escudo;  
        private static float nra;
        
        public Inimigo(string nome)
        {        
            this.nome = nome;
            vida = 100;
            escudo = 100;
        }

         public string GetNome()
         {
            return nome;
         }
            

        public void Danificar(float dano)
        {
            float auxiliar;
            
            escudo -= dano;
            auxiliar = -escudo;
            if(escudo < 0) 
            {
                vida -= auxiliar;
                escudo = 0;
            }
            if(vida < 0) 
            {
                vida = 0;
                Console.WriteLine($"O inimigo {GetNome()} morreu.");
            }
            
        }

        public float GetVida()
        {
            return vida;
        }

        public float GetEscudo()
        {
            return escudo;
        }    
        public void SetNome(string name)
        {
            int aux;

            aux = name.Length;

            if(name[0] == ' ' || name[aux] == ' ')
            {
                nome.Trim(' ');
            }
            
            nome = name;
        }

        public void Abastecer(Abastecimento b, float a)
        {
            if(vida == 0) Console.WriteLine("O inimigo morreu. ");

            if(b == Abastecimento.Escudo)
            {
                escudo += a;
                if(escudo > 100) escudo = 100;
            } else if(b == Abastecimento.Vida)
            {
                vida += a;
                if(vida > 100) vida = 100;
            }

            nra ++;
        }

        public static float GetValor()
        {
            return nra;
        }

        static Inimigo()
        {
            nra = 0;
        } 
    }
}