using System;


namespace OMeuJogo
{
    public class Inimigo
    {
        
        private string nome;
        private float vida;  
        
        public Inimigo(string nome)
        {        
            this.nome = nome;
            vida = 100;
        }

         public string GetNome()
         {
            return nome;
         }
            

        public void Danificar(float dano)
        {
            vida = dano;
            if(vida < 0) vida = 0;
        }

        public float GetVida()
        {
            if(vida <= 50) vida += 50;
            return vida;
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
    }
}