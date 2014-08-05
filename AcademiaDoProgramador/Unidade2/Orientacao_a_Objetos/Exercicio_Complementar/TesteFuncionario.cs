using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteFuncionario
    {
        static void Main6()
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Kalves Oliveira";
            f1.cargo = "Diretor Geral";

            Funcionario f2 = new Funcionario();
            f2.nome = "Keyvinho Alves";
            f2.cargo = "Vice Diretor";

            Console.WriteLine(f1.nome);
            Console.WriteLine(f1.cargo);

            Console.WriteLine(f2.nome);
            Console.WriteLine(f2.cargo);

            Console.ReadKey();
        }
    }
}
