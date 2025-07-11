using System;
using System.Diagnostics;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Soma();
            Subtracao();
            Divisao();
            Multiplicacao();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Calculdadora simples");
            Console.WriteLine("-------------------");
            Console.ReadKey();

            Console.WriteLine("Por favor, escolha a operação que deseja fazer? ");
            Console.WriteLine("");
            Console.WriteLine("1: Soma");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Divisão");
            Console.WriteLine("4: Multiplicação");
            Console.WriteLine("5: Sair da aplicação");

            Console.WriteLine("-------------------");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
            Console.ReadKey();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Soma");
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(v1);

            /*=======================*/

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float Resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é: " + Resultado);
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()

        {
            Console.Clear();

            Console.WriteLine("Subtração");
            Console.WriteLine("Digite o primeiro valor: ");
            float v3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v4 = float.Parse(Console.ReadLine());

            float Resultado2 = v3 - v4;

            Console.WriteLine("O resultado é: " + Resultado2);
            Console.ReadKey();
            Menu();

        }
        static void Divisao()

        {
            Console.WriteLine("Divisão");
            Console.WriteLine("Digite o primeiro valor: ");
            float v5 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v6 = float.Parse(Console.ReadLine());

            float Resultado3 = v5 / v6;

            Console.WriteLine("O resultado é " + Resultado3);

            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Digite o primeiro valor: ");
            float v7 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v8 = float.Parse(Console.ReadLine());

            float Resultado4 = v7 * v8;

            Console.WriteLine("O resultado é: " + Resultado4);

            Console.ReadKey();
            Menu();
        }

    }
}