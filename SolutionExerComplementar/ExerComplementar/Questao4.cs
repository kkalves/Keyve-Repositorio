using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao4
    {
        static void Main4()
        {
            Random numeros = new Random();
            //quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima em estoque.
            int quantidadeAtualEstoque = numeros.Next(0,200);
            int quantidadeMaximaEstoque = 200;
            int quantidadeMinimaEstoque = 10;
            //((quantidade média = quantidade máxima + quantidade mínima) /2)
            int quantidadeMediaEstoque = (quantidadeMaximaEstoque + quantidadeMinimaEstoque) /2;
            if (quantidadeAtualEstoque >= quantidadeMediaEstoque )
            {
                Console.WriteLine("Efetuar Compra!");
            }
            else
            {
                Console.WriteLine("Não efetuar compra!");
            }
            Console.ReadKey();
        }
    }
}
