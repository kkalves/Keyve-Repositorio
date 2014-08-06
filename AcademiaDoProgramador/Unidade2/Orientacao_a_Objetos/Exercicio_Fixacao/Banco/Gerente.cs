using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos.Exercicio_Fixacao.Banco
{
    class Gerente
    {
        public string nome;
        public double salario;

        public void AumentarSalario()
        {
            this.AumentarSalario(0.1);
        }

        public void AumentarSalario(double taxa)
        {
            this.salario += this.salario * taxa;

        }
    }
}
