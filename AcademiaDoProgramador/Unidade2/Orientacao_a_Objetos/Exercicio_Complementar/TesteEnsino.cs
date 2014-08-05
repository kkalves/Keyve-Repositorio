using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteEnsino
    {
        static void Main()
        {
            Turma turma = new Turma();
            turma.periodo = "Vespertino";
            turma.serie = "IV Módulo";
            turma.sigla = "TI";
            turma.tipoDeEnsino = "Técnico";

            Aluno aluno = new Aluno();
            aluno.nome = "Keyve Alves De Oliveira";
            aluno.rg = "1234";
            aluno.dataNascimento = "20/10/1994";

            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Carol";
            funcionario.cargo = "Diretora Geral";

            Console.WriteLine(" ________ \"DADOS ESCOLARES\" ________");
            Console.WriteLine("\n");
            Console.WriteLine(" =========== \"TURMA\" =========== ");
            Console.WriteLine("Periodo: " + turma.periodo);
            Console.WriteLine("Série: " + turma.serie);
            Console.WriteLine("Sigla: " + turma.sigla);
            Console.WriteLine("Tipo de Ensino: " + turma.tipoDeEnsino);
            Console.WriteLine("\n");
            Console.WriteLine(" =========== \"ALUNO\" =========== ");
            Console.WriteLine("Nome: " + aluno.nome);
            Console.WriteLine("RG: " + aluno.rg);
            Console.WriteLine("Data De Nascimento: " + aluno.dataNascimento);
            Console.WriteLine("\n");
            Console.WriteLine(" ======== \"FUNCIONÁRIO\" ======== ");
            Console.WriteLine("Nome: " + funcionario.nome);
            Console.WriteLine("Cargo: " + funcionario.cargo);

            Console.ReadKey();

        }
    }
}
