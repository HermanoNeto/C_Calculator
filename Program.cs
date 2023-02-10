using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            Console.WriteLine("Escolha uma operação: \n(Soma)\n(Divisão)\n(Multiplicação)\n(Subtração)");
            string operacao = Console.ReadLine().ToLower();

            Console.WriteLine("Digite dois números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            if (operacao == "soma")
            {
                resultado = n1 + n2;
            }
            else if (operacao == "divisao")
            {
                resultado = n1 / n2;
            }
            else if (operacao == "multiplicacao")
            {
                resultado = n1 * n2;
            }
            else if (operacao == "subtracao")
            {
                resultado = n1 - n2;
            }
            Console.WriteLine("A {0} dos dois números é: {1}", operacao, resultado);


        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static double Divisao(double a, double b)
        {
            return a / b;
        }

        static int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        static int Subtracao(int a, int b)
        {
            return a - b;
        }
    }
}