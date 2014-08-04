using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao3
    {
        static void Main3(string[] args)
        {
            //número da conta do cliente, saldo, débito e crédito
            Random valores = new Random();
            int numeroConta = valores.Next(0,5000);
            double saldo = valores.Next(0, 500);
            double debito = valores.Next(0, 100);
            double credito = valores.Next(0, 100);
            //saldo atual = saldo - débito + crédito
            double saldoAtual = saldo - debito + credito;
            Console.WriteLine("___________________ \"EXTRATO BANCÁRIO\" ___________________");
            if (saldoAtual >= 0)
            {
                Console.WriteLine("NÚMERO DA CONTA: " + numeroConta);
                Console.WriteLine("SALDO: " + saldo);
                Console.WriteLine("DÉBITO: " + debito);
                Console.WriteLine("CRÉDITO: " + credito);
                Console.WriteLine("SALDO TOTAL DA CONTA: " + saldoAtual);
                Console.WriteLine("SALDO POSITIVO!");
            }
            else
            {
                Console.WriteLine("SALDO TOTAL DA CONTA: " + saldoAtual);
                Console.WriteLine("SALDO NEGATIVO!", saldoAtual);
            }
            Console.ReadKey();
        }
    }
}
