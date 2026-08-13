using System;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {num1 + num2}");
            Console.WriteLine($"Subtração: {num1 - num2}");
            Console.WriteLine($"Multiplicação: {num1 * num2}");

            if (num2 != 0)
                Console.WriteLine($"Divisão: {num1 / num2}");
            else
                Console.WriteLine("Divisão: Não é possível dividir por zero.");
        }
    }
}