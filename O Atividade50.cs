using System;

public class Jogador
{
    public string nome;
    public int idade, estamina;

    public Jogador(string n1,int n2,int n3)
    {
        nome = n1;
        idade = n2;
        estamina = n3;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] n = new string[3];
        int[] v = new int[6];
        Jogador[] jogadores = new Jogador[3];

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("Cadastro do Jogador {0}", i + 1);
            Console.Write("Nome do Jogador: ");
            n[i] = Console.ReadLine();

            Console.Write("Idade do Jogador: ");
            v[i] = int.Parse(Console.ReadLine());

            Console.Write("Estamina Atual do Jogador: ");
            v[i + 1] = int.Parse(Console.ReadLine());

            jogadores[i] = new Jogador(n[i], v[i], v[i + 1]);
        }
        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("Jogador: {0}\nIdade: {1}\nEstamina: {2}", jogadores[i].nome, jogadores[i].idade, jogadores[i].estamina);
        }
        Console.ReadLine();
    }
}