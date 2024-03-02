using System;

internal class Privado
{
    public static void Main()
    {
        int n1, n2, soma;
        string nome;

        Console.Write("Digite Seu Nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite um Numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro numero: ");
        n2 = int.Parse(Console.ReadLine());

        soma = n1 + n2;

        Console.WriteLine("A Some de {0} Mais {1} e Igual a {2}", n1, n2, soma);
    }
}