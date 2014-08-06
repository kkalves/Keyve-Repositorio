using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteConta
    {
        static void Main4()
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.saldo = 200.50;
            c1.limite = 100;

            Conta c2 = new Conta();
            c2.numero = 2;
            c2.saldo = 120.35;
            c2.limite = 100;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);

            Console.WriteLine(c2.numero);
            Console.WriteLine(c2.saldo);
            Console.WriteLine(c2.limite);

            Conta c = new Conta();

            Console.WriteLine(c.numero);
            Console.WriteLine(c.saldo);
            Console.WriteLine(c.limite);

            Console.ReadKey();
        }
    }
}
