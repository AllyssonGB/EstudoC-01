using System;

internal class Principal
{
    public static void Main()
    {
        string[] nome =new string[2];

        Console.Write("Diga Seu Primeiro Nome: ");
        nome[0] = Console.ReadLine();

        Console.Write("Diga Seu Sobrenome: ");
        nome[1] = Console.ReadLine();

        Console.WriteLine("Parabens {0} {1} !!", nome[0], nome[1]);
        Console.ReadLine();

    }
}