using System;

internal class Principal
{
    public static void Main()
    {
        int idade, anos;
        string nome, endereco;

        Console.Write("Diga Seu Nome: ");
        nome = Console.ReadLine();

        Console.Write("Diga seu Endereço: ");
        endereco = Console.ReadLine();

        Console.Write("Diga Sua Idade: ");
        idade = int.Parse(Console.ReadLine());

        anos = idade + 30;
        Console.WriteLine("Nome......: {0}", nome);
        Console.WriteLine("Endereço..: {0}", endereco);
        Console.WriteLine("Idade.....: {0}", idade);
        Console.WriteLine("30 Anos +.: {0}", anos);
    }
}