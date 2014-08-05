using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Exercicio4
    {
        static void Main4(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 4;
                if (resto == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(contador);
                }

            }
            Console.ReadKey();
        }
    }
}
