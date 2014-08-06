using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class Funcionario
    {
        public string nome;
        public string cargo;
        public double salario;

        public void AumentarSalario(double valor)
        {
            salario += valor;

        }

        public string ConsultarDadosFuncionarios()
        {
            string dadosFuncionario = "";
            dadosFuncionario += "========== DADOS FUNCIONÁRIO =========="
                                + "\n" + "Nome: " + nome
                                + "\n" + "Cargo: " + cargo
                                + "\n" + "Salário: " + salario;
            return dadosFuncionario;
        }

    }
}
