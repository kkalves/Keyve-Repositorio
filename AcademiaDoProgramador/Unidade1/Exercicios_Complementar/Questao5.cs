using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao5
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("_____________ \"POSTO DE GASOLINA\" _____________");
            Console.WriteLine("========== COMBUSTÍVEL ==========");
            Console.WriteLine("A - ÁLCOOL");
            Console.WriteLine("G - GASOLINA");
            Console.WriteLine("Informe o combustível desejado: ");
            string opcao = Console.ReadLine();
            char tipoCombustivel = Convert.ToChar(opcao);
            Random quantidade = new Random();
            int quantidadeLitros = quantidade.Next(1, 100);
            double totalPagar = 0;
            double precoGasolina = 3.30;
            double precoAlcool = 2.90;
            if (tipoCombustivel == 'A')
            {
                Console.WriteLine("Combustível Escolhido - Álcool");
                if (quantidadeLitros < 20)
                {
                    totalPagar = quantidadeLitros * (precoAlcool - (precoAlcool * 0.03));
                    Console.WriteLine("Preço do Litro: " + (precoAlcool - (precoAlcool * 0.03)));
                }
                else
                {
                    totalPagar = quantidadeLitros * (precoAlcool - (precoAlcool * 0.05));
                    Console.WriteLine("Preço do Litro: " + (precoAlcool - (precoAlcool * 0.05)));
                }
            }

            if (tipoCombustivel == 'G')
            {
                Console.WriteLine("Combustível Escolhido - Gasolina");
                if (quantidadeLitros < 20)
                {
                    totalPagar = quantidadeLitros * (precoGasolina - (precoGasolina * 0.04));
                    Console.WriteLine("Preço do Litro: " + (precoGasolina - (precoGasolina * 0.04)));
                }
                else
                {
                    totalPagar = quantidadeLitros * (precoGasolina - (precoGasolina * 0.06));
                    Console.WriteLine("Preço do Litro: " + (precoGasolina - (precoGasolina * 0.06)));
                }
            }

            Console.WriteLine("Quantidade de Litros vendidos: " + quantidadeLitros);
            Console.WriteLine("Total a pagar: " + totalPagar);
            Console.ReadKey();
        }
    }
}
