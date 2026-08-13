using System;

namespace ConversorDeMoedas
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite o valor em reais (R$): ");
            double reais = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dólar (US$): ");
            double cotacao = double.Parse(Console.ReadLine());

            double dolares = reais / cotacao;
            Console.WriteLine($"O valor em dólares é: US$ {dolares:F2}");
        }
    }
}