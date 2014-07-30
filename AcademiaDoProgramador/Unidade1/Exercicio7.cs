using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Exercicio7
    {
        static void Main7()
        {
            int valor1 = 0;
            int valor2 = 1;
            for (int cont = 0; cont <= 50; cont++)
            {
                int resultado = valor1 + valor2;
                Console.WriteLine(resultado);
                valor1 = valor2;
                valor2 = resultado;
            }
            Console.ReadKey();
        }
    }
}
