using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteCartaoDeCredito
    {
        static void Main2()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 1928738;
            cdc1.dataDeValidade = "20/10/2015";
            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 3312898;
            cdc2.dataDeValidade = "14/02/2010";

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);

            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);
            Console.ReadKey();
        }
    }
}
