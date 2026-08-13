using System;

namespace ContagemDePares
{
    internal class Program
    {
        static void Main()
        {
            int pares = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares digitados: {pares}");
        }
    }
}