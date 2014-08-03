using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao3
    {
        static void Main3()
        {
            //número da conta do cliente, saldo, débito e crédito
            Random valores = new Random();
            int numeroConta = valores.Next(0,5000);
            double saldo = valores.Next(0, 500);
            double debito = valores.Next(0, 500);
            double credito = valores.Next(0, 500);
            //saldo atual = saldo - débito + crédito
            double saldoAtual = saldo - debito + credito;
            if (saldoAtual >= 0)
            {
                Console.WriteLine("Saldo Positivo!", saldoAtual);
            }
            else
            {
                Console.WriteLine("Saldo Negativo!", saldoAtual);
            }
            Console.ReadKey();
        }
    }
}
