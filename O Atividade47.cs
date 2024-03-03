using System;

public class Jogador
{
    public string nome;
    public int velocidade;
    public int idade;
    public string esporte;

    public Jogador(string nome1, int n1, int n2, string esporte1)
    {
        nome = nome1;
        velocidade = n1;
        idade = n2;
        esporte = esporte1;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] l = new string[8];
        int[] n = new int[8];
        Jogador[] jogadores = new Jogador[4];

        for (int i = 0; i < 4; i += 1)
        {
            Console.WriteLine("Cadastro do {0} Jogador", i+1);
            Console.Write("Digite o Nome do Jogador: ");
            l[i+4] = Console.ReadLine();

            Console.Write("Digite a Velocidade do Jogador: ");
            n[i+4] = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade do Jogador: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Digite o Esporte que ele joga: ");
            l[i] = Console.ReadLine();

            jogadores[i] = new Jogador(l[i+4], n[i+4], n[i], l[i]);
        }
        for (int u = 0; u < 4; u += 1)
        {
            Console.WriteLine("O Jogador {0} Tem Velocidade {1} é Idade {2} É Ele joga {3}", jogadores[u].nome, jogadores[u].velocidade, jogadores[u].idade, jogadores[u].esporte);
        }
        Console.ReadLine();


    }
}