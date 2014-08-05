using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Exercicio8
    {
        static void Main()
        {
            int opc = 1;

            while (opc != 0)
            {
                opc = Menu();
                if(opc == 0){
                    Console.WriteLine("Bye Bye!");
                }
                else if(opc == 1)
                {
                    Console.WriteLine("Padrão 1");
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resto = contador % 2;
                        if (resto == 1)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.WriteLine("**");
                        }
                    }
                }
                else if(opc == 2){
                    Console.WriteLine("Padrão 2");
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resto = contador % 4;
                        if (resto == 0)
                        {
                            Console.WriteLine("PI");
                        }
                        else
                        {
                            Console.WriteLine(contador);
                        }
                    }
                }
                else if (opc == 3){
                    for (int contador = 1; contador <= 30; contador++)
                    {
                        int quantidadeCaractere = contador;
                        while (quantidadeCaractere > 0)
                        {
                            Console.Write("*");
                            quantidadeCaractere--;
                        }
                        Console.Write("\n");
                    }
                }
                else if(opc == 4){
                    for (int repeticao = 1; repeticao <= 3; repeticao++)
                    {
                        for (int contador = 1; contador <= 5; contador++)
                        {
                            int quantidadeCaractere = contador;
                            while (quantidadeCaractere > 0)
                            {
                                Console.Write("*");
                                quantidadeCaractere--;
                            }
                            Console.Write("\n");
                        }
                    }  

                }
                else if(opc == 5){
                    int valor1 = 0;
                    int valor2 = 1;
                    for (int cont = 0; cont <= 10; cont++)
                    {
                        int resultado = valor1 + valor2;
                        Console.WriteLine(resultado);
                        valor1 = valor2;
                        valor2 = resultado;
                    }
                }
            }
            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1 - Padrão 1");
                Console.WriteLine("2 - Padrão 2");
                Console.WriteLine("3 - Padrão 3");
                Console.WriteLine("4 - Padrão 4");
                Console.WriteLine("5 - Padrão 5");
                Console.WriteLine("0 - Fechar");
                int opcao = int.Parse(Console.ReadLine());
            return opcao;
            }
        }
    }

