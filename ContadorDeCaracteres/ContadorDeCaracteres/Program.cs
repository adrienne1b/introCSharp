using System;

namespace ContadorDeCaracteres
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"O nome {nome} possui {nome.Length} caracteres.");
        }
    }
}