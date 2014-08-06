using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteFuncionario
    {
        static void Main1()
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Kalves Oliveira";
            f1.cargo = "Diretor Geral";
            f1.salario = 2000;

            Console.WriteLine(f1.ConsultarDadosFuncionarios());

            f1.AumentarSalario(1000);

            Console.WriteLine(f1.ConsultarDadosFuncionarios());

            Funcionario f2 = new Funcionario();
            f2.nome = "Keyvinho Alves";
            f2.cargo = "Vice Diretor";
            f2.salario = 1500;

            Console.WriteLine(f2.ConsultarDadosFuncionarios());

            f2.AumentarSalario(590);

            Console.WriteLine(f2.ConsultarDadosFuncionarios());

            Console.ReadKey();
        }
    }
}
