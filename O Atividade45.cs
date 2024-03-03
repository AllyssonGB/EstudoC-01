using System;

public class Jogador
{
    public int idade;
    public string nome;

    public Jogador(int n1, string nome1)
    {
        idade = n1;
        nome = nome1;
    }
}

internal class Principal
{
    public static void Main()
    {
        int k1,k2;     // k1 e o numero da idade
        string k3,k4;   // k2 e a string
        Jogador j1, j2;

        Console.Write("Digite o nome do Primeiro Jogador: ");
        k3 = Console.ReadLine();

        Console.Write("Digite a idade do Primeiro Jogador: ");
        k1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do Segundo Jogador: ");
        k4 = Console.ReadLine();

        Console.Write("Digite a idade do Segundo Jogador: ");
        k2 = int.Parse(Console.ReadLine());

        j1 = new Jogador(k1, k3);
        j2 = new Jogador(k2, k4);

        Console.WriteLine("Jogador 1 Se Chama {0} é Tem Idade de {1}", j1.nome, j1.idade);
        Console.WriteLine("Jogador 2 Se Chama {0} é Tem Idade de {1}", j2.nome, j2.idade);
        Console.ReadLine();
    }
}