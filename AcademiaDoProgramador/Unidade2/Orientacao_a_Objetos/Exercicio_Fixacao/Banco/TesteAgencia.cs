using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteAgencia
    {
        static void Main3()
        {
            Agencia a1 = new Agencia();
            a1.numero = 12345;

            Agencia a2 = new Agencia();
            a2.numero = 87893;

            Console.WriteLine(a1.numero);

            Console.WriteLine(a2.numero);

            Console.ReadKey();
        }
    }
}
