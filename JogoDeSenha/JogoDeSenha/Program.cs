using System;

namespace JogoDeSenha
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(1, 101);
            int palpite;

            Console.WriteLine("Jogo da Senha: Adivinhe o número entre 1 e 100!");

            do
            {
                Console.Write("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é MAIOR.");
                }
                else if (palpite > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é MENOR.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número sorteado!");
                }
            } while (palpite != numeroSorteado);
        }
    }
}