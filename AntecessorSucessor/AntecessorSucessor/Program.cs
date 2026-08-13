using System;

namespace AntecessorSucessor
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Antecessor: {numero - 1}");
            Console.WriteLine($"Número informado: {numero}");
            Console.WriteLine($"Sucessor: {numero + 1}");
        }
    }
}