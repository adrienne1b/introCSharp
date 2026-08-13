using System;

namespace SomaNumerosPares
{
    internal class Program
    {
        static void Main()
        {
            int soma = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                soma += i;
            }

            Console.WriteLine($"A soma de todos os números pares entre 1 e 100 é: {soma}");
        }
    }
}