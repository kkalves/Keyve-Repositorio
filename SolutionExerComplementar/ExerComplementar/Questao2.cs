using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao2
    {
        static void Main2()
        {
            //precisa terminar
            int horasMensal = 0;
            int horasSemanal = 40;
            double salarioHora = 1.5;
            double salarioTotal = 0.0;
            int horasExtras = 0;

            if (true)
	        {
                //caso não exista hora extra
                salarioTotal = horasMensal * salarioHora;
	        }
            else
            {
                //caso o funcionario tenha realizado hora extra
                salarioTotal = salarioHora + (horasExtras * (salarioHora + (salarioHora * 0.5)));
            }
            Console.WriteLine("Salário total: ", salarioTotal);
            Console.ReadKey();
        }
    }
}
