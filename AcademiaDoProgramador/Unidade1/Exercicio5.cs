using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Exercicio5
    {
        static void Main5()
        {
            for (int contador = 1; contador <= 50; contador++)
            {
                int quantidadeCaractere = contador;
                while (quantidadeCaractere > 0 )
                {
                    Console.Write("*");
                    quantidadeCaractere--;
                }
                Console.Write("\n");
            }
                Console.ReadKey();
        }
    }
}
