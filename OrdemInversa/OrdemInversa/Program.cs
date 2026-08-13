using System;

namespace OrdemInversa
{


    internal class Program
    {
        static void Main()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros na ordem inversa:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}