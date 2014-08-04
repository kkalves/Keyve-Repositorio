using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerComplementar
{
    class Questao4
    {
        static void Main4(string[] args)
        {
            Random numeros = new Random();
            //quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima em estoque.
            int quantidadeAtualEstoque = numeros.Next(0,200);
            int quantidadeMaximaEstoque = 100;
            int quantidadeMinimaEstoque = 10;
            //((quantidade média = quantidade máxima + quantidade mínima) /2)
            int quantidadeMediaEstoque = (quantidadeMaximaEstoque + quantidadeMinimaEstoque) /2;
            Console.WriteLine("_____________________ \"CONTROLE DE ESTOQUE\" _____________________");
            Console.WriteLine("QUANTIDADE ATUAL: " + quantidadeAtualEstoque);
            Console.WriteLine("QUANTIDADE MÁXIMA: " + quantidadeMaximaEstoque);
            Console.WriteLine("QUANTIDADE MÍNIMA: " + quantidadeMinimaEstoque);
            Console.WriteLine("QUANTIDADE MÉDIA: " + quantidadeMediaEstoque);
            if (quantidadeAtualEstoque >= quantidadeMediaEstoque )
            {
                Console.WriteLine("EFETUAR COMPRA!");
            }
            else
            {
                Console.WriteLine("NÂO EFETUAR COMPRA!");
            }
            Console.ReadKey();
        }
    }
}
