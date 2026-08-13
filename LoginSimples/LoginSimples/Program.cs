using System;

namespace LoginSimples
{
    internal class Program
    {
        static void Main()
        {
            string usuarioCorreto = "admin";
            string senhaCorreta = "12345";

            Console.Write("Digite o usuário: ");
            string usuario = Console.ReadLine();

            string senha;
            do
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                if (senha != senhaCorreta || usuario != usuarioCorreto)
                {
                    Console.WriteLine("Credenciais incorretas! Tente novamente.");
                }
            } while (senha != senhaCorreta || usuario != usuarioCorreto);

            Console.WriteLine("Login realizado com sucesso!");
        }
    }
}