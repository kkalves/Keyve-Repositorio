using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Exercicio3
    {
        static void Main3(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
                
            }
            Console.ReadKey();
        }
    }
}
