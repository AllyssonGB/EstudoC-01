using System;

public class Jogador
{
    public string nome;
    public int idade, dinheiro;

    public Jogador(string n1, int n2, int n3)
    {
        nome = n1;
        idade = n2;
        dinheiro = n3;
    }

    public Jogador(string n1,int n2)
    {
        nome = n1;
        idade = n2;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] l = new string[4];
        int[] n = new int[6];
        Jogador[] jogadores = new Jogador[4];

        for (int i = 0; i < 2; i += 1)
        {
            Console.WriteLine("Cadastro do Jogador {0}", i + 1);
            Console.Write("Nome do Jogador: ");
            l[i] = Console.ReadLine();

            Console.Write("Idade Do Jogador: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Saldo Do Jogador: ");
            n[i + 1] = int.Parse(Console.ReadLine());

            jogadores[i] = new Jogador(l[i], n[i], n[i + 1]);
        }

        for (int i = 2;i < 4;i += 1)
        {
            Console.WriteLine("Cadastro do Jogador {0}", i + 1);
            Console.Write("Idade do Jogador: ");
            l[i] = Console.ReadLine();

            Console.Write("Idade do Jogador");
            n[i + 2] = int.Parse(Console.ReadLine());

            jogadores[i] = new Jogador(l[i], n[i + 2]);
        }

        for (int i = 0; i < 2 ; i += 1)
        {
            Console.WriteLine("{0} Jogador Com {1} Anos de Idade é {2} de Saldo ", jogadores[i].nome, jogadores[i].idade, jogadores[i].dinheiro);
        }
        for (int i = 2; i < 4; i += 1)
        {
            Console.WriteLine("{0} Jogador Com {1} Anos de Idade ", jogadores[i].nome, jogadores[i].idade);
        }
        Console.ReadLine();
    }
}