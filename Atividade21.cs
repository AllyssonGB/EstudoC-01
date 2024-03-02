using System;

internal class Privado
{
    public static void Main()
    {
        int[] n = { 0, 0, 0 };
        string nome;

        Console.Write("Digite Um Numero: ");
        n[0] = int.Parse(Console.ReadLine());

        Console.Write("Diga Outro Numero: ");
        n[1] = int.Parse(Console.ReadLine());

        n[2] = n[0] + n[1];

        if (n[2] > 50)
        {
            Console.WriteLine("Maior Que 50");
        }
        else if (n[2] < 50)
        {
            Console.WriteLine("Menor Que 50");
        }
        else if (n[2] == 50)
        {
            Console.WriteLine("Igual a 50");
        }
        else
        {
            Console.WriteLine("Erro");
        }

        Console.Write("Diga Seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Parabens {0}.", nome);

    }

}