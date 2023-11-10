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
    }
}