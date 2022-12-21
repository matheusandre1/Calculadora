using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Opções de realização");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Seleciona uma dessas opções");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Multiplicacao(); break;

                case 4: Divisao(); break;

                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;





            }
        }

        static void Soma()
        {
            Console.WriteLine();
            Console.WriteLine("Primeiro Valor:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor + valor2;

            Console.WriteLine("o valor do resultado é :" + resultado);
            Console.ReadKey();
            Menu();


        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("O resultado é : ");
            double resultado = (v1 - v2);

            Console.WriteLine("o Resultado é : " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro Valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultadodivisao = (valor1 / valor2);
            Console.WriteLine("A divisão é" + resultadodivisao);
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultadomultiplicacao = valor1 * valor2;

            Console.WriteLine("resultado é :" + resultadomultiplicacao);
            Console.ReadKey();
            Menu();
        }
    }
}