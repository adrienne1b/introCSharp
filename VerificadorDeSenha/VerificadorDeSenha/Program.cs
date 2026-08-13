using System;

namespace VerificadorDeSenha
{
    class Program
    {
        
       internal static void Main()
        {
            Console.Write("Digite uma senha: ");
            string senha = Console.ReadLine();

            if (senha.Length >= 8)
            {
                Console.WriteLine("A senha possui pelo menos 8 caracteres.");
            }
            else
            {
                Console.WriteLine("A senha é muito curta. Deve possuir pelo menos 8 caracteres.");
            }
        }
    }
}