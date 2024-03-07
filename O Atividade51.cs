using System;

public class Pessoa
{
    public string nome;
    public int idade;
    public float dinheiro;

    public Pessoa(string n1,int n2,float n3)
    {
        nome = n1;
        idade = n2;
        dinheiro = n3;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] s = new string[3];
        int[] n = new int[3];
        float[] f = new float[3];
        Pessoa[] pessoas = new Pessoa[3];

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("Cadastro da Pessoa {0}", i + 1);
            Console.Write("Nome da Pessoa: ");
            s[i] = Console.ReadLine();

            Console.Write("Idade da Pessoa: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Saldo da Pessoa: ");
            f[i] = float.Parse(Console.ReadLine());

            pessoas[i] = new Pessoa(s[i], n[i], f[i]);
        }

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("{0} Tem {1} Anos é {2} de Saldo", pessoas[i].nome, pessoas[i].idade, pessoas[i].dinheiro);
        }

        Console.ReadLine();
    }
}