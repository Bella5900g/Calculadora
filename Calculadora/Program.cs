using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }


        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Console.WriteLine("====================================");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine("====================================");

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();



            }


        }

        static void Soma()

        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultadoda soma é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }

        static void Sub()

        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultadoda da Subtração é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }

        static void Div()

        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultadoda da Divisão é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }

        static void Mult()

        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultadoda da Multiplicação é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }

        static void Pot()

        {
            Console.WriteLine("Potência de dois numeros: ");
            Console.WriteLine("Digite qa Base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultadoda é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }
        static void Raiz()

        {
            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite qa Base: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultadoda é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }
    }
}
