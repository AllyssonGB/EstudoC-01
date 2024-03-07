using System;

public class Jogador
{
    public string nome;
    public int idade;
    public float peso, dinheiro;

    public Jogador(string n1,int n2, float n3, float n4)
    {
        nome = n1;
        idade = n2;
        peso = n3;
        dinheiro = n4;
    }

    public Jogador(string a1, int a2, float a3)
    {
        nome = a1;
        idade = a2;
        dinheiro = a3;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] n = new string[4];
        int[] l = new int[4];
        float[] f = new float[6];
        Jogador[] jogadores = new Jogador[4];

        for (int i = 0; i < 2; i += 1)
        {
            Console.WriteLine("Cadastro da {0} Pessoa", i + 1);
            Console.Write("Qual Nome Dessa Pessoa: ");
            n[i] = Console.ReadLine();

            Console.Write("Digite A Idade Dessa Pessoa: ");
            l[i] = int.Parse(Console.ReadLine());

            Console.Write("Digite o Peso Dessa Pessoa: ");
            f[i] = float.Parse(Console.ReadLine());

            Console.Write("Digite o Saldo Atual dessa Pessoa: ");
            f[i + 1] = float.Parse(Console.ReadLine());

            jogadores[i] = new Jogador(n[i], l[i], f[i], f[i + 1]);
        }

        for (int i = 2; i < 4; i += 1)
        {
            Console.WriteLine("Cadastro da {0} Jogador", i + 1);
            Console.Write("Nome do Jogador: ");
            n[i] = Console.ReadLine();

            Console.Write("Digite A Idade do Jogador: ");
            l[i] = int.Parse(Console.ReadLine());

            Console.Write("Digite o Saldo Dessa Pessoa: ");
            f[i + 2] = float.Parse(Console.ReadLine());

            jogadores[i] = new Jogador(n[i], l[i], f[i + 2]);
        }

        for (int i = 0; i < 2; i += 1)
        {
            Console.WriteLine("{0} Com Idade de {1} é Peso de {2} Tem R${3} Reais", 
                jogadores[i].nome, jogadores[i].idade, jogadores[i].peso, jogadores[i].dinheiro);
        }

        for (int i = 2; i < 4; i += 1)
        {
            Console.WriteLine("Jogador {0} Com Idade de {1} é Saldo de {2}", jogadores[i].nome, jogadores[i].idade, jogadores[i].dinheiro);
        }
        Console.ReadLine();

    }
}