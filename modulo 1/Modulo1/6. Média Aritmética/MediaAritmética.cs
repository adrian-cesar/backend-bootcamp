/* ## 6. Média Aritmética
 * 
 * Crie um programa que solicite ao usuário que digite três notas, 
 * em seguida, converta cada valor para `double` 
 * e calcule a média final. Exiba a média no console formatada com duas casas decimais.
 * 
 * Saída esperada:
 * Digite a primeira nota: 7.5
 * Digite a segunda nota: 8.0
 * Digite a terceira nota: 6.5
 * A média das notas é: 7.33
 */

using System;

class MediaAritmetica
{
    public static void Executar()
    {
        Console.WriteLine("Digite sua primeira nota :");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Digite sua segunda nota :");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Digite sua terceira nota :");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Clear();

        double media = 0;

        Console.WriteLine($"Sua media e : {(nota1 + nota2 + nota3) / 3}");

    }
}

