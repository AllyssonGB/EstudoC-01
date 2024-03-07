using System;

public class Jogador
{
    public string nome;
    public int idade, energia, vidas;
    public bool vivo;

    public Jogador(string nome, int idade, int energia, int vidas)
    {
        this.nome = nome;
        this.idade = idade;
        this.energia = energia;
        this.vidas = vidas;
        this.vivo = true;
    }
    public Jogador(string nome, int idade, int energia, int vidas, bool vivo)
    {
        this.nome = nome;
        this.idade = idade;
        this.energia = energia;
        this.vidas = vidas;
        this.vivo = vivo;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] s = new string[4];
        int[] n = new int[16];
        bool[] b = new bool[4];
        Jogador[] jogadores = new Jogador[4];

        for (int i = 0; i < 2; i += 1)
        {
            Console.WriteLine("Cadastro do Jogador {0}", i + 1);
            Console.Write("Nome: ");
            s[i] = Console.ReadLine();

            Console.Write("Idade: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Energia: ");
            n[i + 1] = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de Vidas: ");
            n[i + 2] = int.Parse(Console.ReadLine());

            Console.Write("Vivo ou Morto [V/M]: ");
            string input = Console.ReadLine().ToUpper();
            if(input == "V")
            {
                b[i] = true;
            }
            else
            {
                b[i] = false;
            }

            jogadores[i] = new Jogador(s[i], n[i], n[i + 1], n[i + 2], b[i]);
        }

        for (int i = 2; i < 4; i += 1)
        {
            Console.WriteLine("Cadastro do Jogador {0}", i + 1);
            Console.Write("Nome: ");
            s[i] = Console.ReadLine();

            Console.Write("Idade: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Energia: ");
            n[i + 1] = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de Vidas: ");
            n[i + 2] = int.Parse(Console.ReadLine());

            jogadores[i] = new Jogador(s[i], n[i], n[i + 1], n[i + 2]);
        }

        for (int i = 0; i < 4; i += 1)
        {
            Console.WriteLine("Dados do {0} Jogador", i + 1);
            Console.WriteLine("Nome: {0}", jogadores[i].nome);
            Console.WriteLine("Idade: {0}", jogadores[i].idade);
            Console.WriteLine("Energia: {0}", jogadores[i].energia);
            Console.WriteLine("Quantidade de Vidas: {0}", jogadores[i].vidas);
            if (jogadores[i].vivo == true)
            {
                Console.WriteLine("Esta Vivo: Verdadeiro");
            }
            else
            {
                Console.WriteLine("Esta Vivo: Falso");
            }
            Console.WriteLine("---------------------------");
        }
        Console.ReadLine();
    }
}
