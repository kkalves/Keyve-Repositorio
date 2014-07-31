using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Exercicio6
    {
        static void Main()
        {
            for (int repeticao = 1; repeticao <= 10; repeticao++)
            {
                for (int contador = 1; contador <= 10; contador++)
                {
                    int quantidadeCaractere = contador;
                    while (quantidadeCaractere > 0)
                    {
                        Console.Write("*");
                        quantidadeCaractere--;
                    }
                    Console.Write("\n");
                }
            }   
            Console.ReadKey();
        }
    }
}
