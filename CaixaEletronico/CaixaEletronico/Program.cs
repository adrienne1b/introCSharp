using System;

namespace CaixaEletronico
    {
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o valor para saque: R$ ");
            int valor = int.Parse(Console.ReadLine());

            int[] notas = { 100, 50, 20, 10, 5, 2 };

            Console.WriteLine("Notas entregues:");
            foreach (int nota in notas)
            {
                int quantidadeNotas = valor / nota;
                if (quantidadeNotas > 0)
                {
                    Console.WriteLine($"{quantidadeNotas} nota(s) de R${nota}");
                    valor %= nota;
                }
            }

            if (valor > 0)
            {
                Console.WriteLine($"Sobrou R${valor} que não pode ser sacado com as notas disponíveis.");
            }
        }
    }
}