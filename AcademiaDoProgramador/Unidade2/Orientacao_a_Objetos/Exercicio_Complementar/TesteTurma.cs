using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteTurma
    {
        static void Main7()
        {
            Turma t1 = new Turma();
            t1.periodo = "matutino";
            t1.serie = "2ª ano";
            t1.sigla = "abc";
            t1.tipoDeEnsino = "Médio";

            Turma t2 = new Turma();
            t2.periodo = "Noturno";
            t2.serie = "4 módulo";
            t2.sigla = "hgd";
            t2.tipoDeEnsino = "Superior";

            Console.WriteLine(t1.periodo);
            Console.WriteLine(t1.serie);
            Console.WriteLine(t1.sigla);
            Console.WriteLine(t1.tipoDeEnsino);

            Console.WriteLine(t2.periodo);
            Console.WriteLine(t2.serie);
            Console.WriteLine(t2.sigla);
            Console.WriteLine(t2.tipoDeEnsino);

            Console.ReadKey();
        }
    }
}
