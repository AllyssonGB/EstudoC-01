using System;

internal class Private
{
    public static void Main()
    {
        int n1, n2, soma;

        Console.Write("Digite um numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite Outro Numero: ");
        n2 = int.Parse(Console.ReadLine());

        soma = n1 + n2;

        Console.WriteLine("O Valor da Soma entre {0} é {1} é Igual a {2}", n1, n2, soma);
    }
}