using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos.Exercicio_Fixacao.Banco
{
    class TesteGerente
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            gerente.nome = "Keyve Alves De Oliveira";
            gerente.salario = 1234;

            Console.WriteLine(" ==== Dados Gerente ===");
            Console.WriteLine("Nome: " + gerente.nome);
            Console.WriteLine("Salario: " + gerente.salario);

            Console.WriteLine("***** Salario aumentando em 10% *****");
            gerente.AumentarSalario();
            Console.WriteLine(" ==== Dados Gerente ===");
            Console.WriteLine("Nome: " + gerente.nome);
            Console.WriteLine("Salario: " + gerente.salario);

            Console.WriteLine("*** Aumentando a taxa do salário do gerente com valor diferente de 10% ***");
            gerente.AumentarSalario(0.3);
            Console.WriteLine(" ==== Dados Gerente ===");
            Console.WriteLine("Nome: " + gerente.nome);
            Console.WriteLine("Salario: " + gerente.salario);

            Console.ReadKey();
        }
    }
}
