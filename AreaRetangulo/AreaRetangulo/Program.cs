using System;

namespace AreaTriangulo
{ 
internal class Program
{
    static void Main()
    {
        Console.Write("Digite a base do retângulo: ");
        double baseRet = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine());

        double area = baseRet * altura;
        double perimetro = 2 * (baseRet + altura);

        Console.WriteLine($"Área: {area}");
        Console.WriteLine($"Perímetro: {perimetro}");
    }
}
}