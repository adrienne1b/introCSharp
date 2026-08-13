using System;

namespace MaiorElemento
{
    internal class Program
    {
        static void Main()
        {
            int[] numeros = new int[10];
            int maior = int.MinValue;
            int posicao = -1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i + 1; // Posição amigável (1-indexed)
                }
            }

            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Posição em que ele aparece: {posicao}");
        }
    }
}