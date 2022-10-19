using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Program
    {
        static void Main(string[] args)
        {


            string jogarNovamente = "s";
            bool ganhou = false;
            int ganhador;
            int aposta = 0;

            while (jogarNovamente.Equals("s")) {
            Pista pista1 = new Pista(100, new Corredor("a"));
            Pista pista2 = new Pista(100, new Corredor("b"));
            Pista pista3 = new Pista(100, new Corredor("c"));


            Console.Clear();    
            Console.WriteLine("%$#@ - CORRIDA MALUCA - @#$%");
            Console.WriteLine();

            Console.WriteLine("Em qual corredor você aposta? \n1 - a \n2 - b \n3 - c ");
                aposta = int.Parse(Console.ReadLine());

            ganhador = 0;

               ganhou = false;
            while (ganhou == false)
            {
                Console.Clear();
                if (pista1.atualizarCorrida())
                {
                    ganhou = true;
                    ganhador = 1;
                } 
                pista1.ExibirPista();

                if (pista2.atualizarCorrida())
                {
                    ganhou = true;
                    ganhador = 2;
                }
                pista2.ExibirPista();

                if (pista3.atualizarCorrida())
                {
                    ganhou = true;
                    ganhador = 3;
                }
                pista3.ExibirPista();

                //Console.ReadKey();

                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine($"O ganhador foi o corredor Nº {ganhador}");

            if(ganhador == aposta)
            {
                Console.WriteLine("Parabéns! Você ganhou a aposta! :) ");
            }
            else
            {
                Console.WriteLine("Você não venceu. Mais sorte na próxima :( ");
            }

                Console.WriteLine("Jogar novamente? \ns = sim  \nn = não");
                jogarNovamente = Console.ReadLine();

            }

            Console.WriteLine("Fim do Jogo!");
        }
    }
}
