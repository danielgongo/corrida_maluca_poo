using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Corredor
    {
       public static Random aleatorio = new Random();

        public Corredor()
        {
            this.Nome = "";
           
        }

        public Corredor(string nome)
        {
            this.Nome = nome;
            
        }

        private string nome;
        public string Nome 
        { 
            get { return this.nome; }
            set
            {
                this.nome = value;

                if (value.Length > 1) this.nome = value[0].ToString();
                //Caso o nome receba mais de 1 caracter, vai pegar apenas o primeiro e colocar como nome do corredor

                if (value.Length == 0) this.nome = "Y";

               
            }
        
        }

        

        public int Correr()
        {
            return Corredor.aleatorio.Next(1, 10); //O quanto o corredor vai andar aleatoriamente
        }
    }
}
