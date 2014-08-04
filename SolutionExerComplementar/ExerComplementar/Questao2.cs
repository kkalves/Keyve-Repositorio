using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao2
    {
        static void Main(string[] args)
        {
            Random horas = new Random();
            int horasMensal = horas.Next(0,200);
            double salarioHora = 3.20;
            double salarioTotal = 0.0;
            int horasExtras = 0;

            if (horasMensal <= 160)
	        {
                salarioTotal = horasMensal * salarioHora;
	        }
            else
            {
                horasExtras = horasMensal - 160;
                salarioTotal = (salarioHora * 160) + (horasExtras * (salarioHora + (salarioHora * 0.5)));
            }
            Console.WriteLine("HORAS TRABALHADAS NO MÊS: " + horasMensal);
            Console.WriteLine("SALARIO HORA: " + salarioHora);
            Console.WriteLine("SALARIO TOTAL: " + salarioTotal);
            Console.ReadKey();
        }
    }
}
