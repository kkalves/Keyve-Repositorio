using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao1
    {
        static void Main1()
        {
            Random horas = new Random();
            int inicioPartida = horas.Next(0, 24);
            int horaInicio = inicioPartida;
            int finalPartida = horas.Next(0, 24);
            int duracaoPartida = 0;
            while (horaInicio != finalPartida)
            {
                if (horaInicio >= 24)
                {
                    horaInicio = 0;
                    horaInicio++;
                }
                else
                {
                    horaInicio++;        
                }
                duracaoPartida++;
            }
            //Problemas no mostrar os resultados.
            Console.WriteLine("A partida iniciou às: ", (inicioPartida), "horas");
            Console.WriteLine("A partida durou cerca de ", duracaoPartida, "rodadas");
            Console.WriteLine("A partida terminou às: ", finalPartida, "horas");
            Console.ReadKey();
        }
    }
}
