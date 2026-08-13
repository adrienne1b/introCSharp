using System;

namespace SomaAteDigitarZero
{
    internal class Program
    {
        static void Main()
        {
            int soma = 0;
            int numero;

            do
            {
                Console.Write("Digite um número (ou 0 para encerrar): ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            } while (numero != 0);

            Console.WriteLine($"A soma dos valores digitados é: {soma}");
        }
    }
}