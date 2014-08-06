using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteAluno
    {
        static void Main5()
        {
            Aluno a1 = new Aluno();
            a1.nome = "Keyve Alves De Oliveira";
            a1.rg = "1234";
            a1.dataNascimento = "20/10/1994";

            Aluno a2 = new Aluno();
            a2.nome = "Keyve Alves";
            a2.rg = "4321";
            a2.dataNascimento = "10/10/2010";

            Console.WriteLine(a1.nome);
            Console.WriteLine(a1.rg);
            Console.WriteLine(a1.dataNascimento);

            Console.WriteLine(a2.nome);
            Console.WriteLine(a2.rg);
            Console.WriteLine(a2.dataNascimento);

            Console.ReadKey();
        }
    }
}
