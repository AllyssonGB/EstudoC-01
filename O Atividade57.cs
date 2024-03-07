using System;

public class Jogos
{
    public string nome;
    public float nota;
    public int lançamento;
    public bool jg;

    public Jogos(string nome, float nota, int lançamento, bool jg)      // 3
    {
        this.nome = nome;
        this.nota = nota;
        this.lançamento = lançamento;
        this.jg = jg;
    }

    public Jogos(string nome, float nota, int lançamento)               // 2
    {
        this.nome = nome;
        this.nota = nota;
        this.lançamento = lançamento;
        this.jg = false;
    }
}

public class Jogador
{
    public string nome;
    public int idade;
    public bool gamer;

    public Jogador(string nome, int idade, bool gamer)              // 3
    {
        this.nome = nome;
        this.idade = idade;
        this.gamer = gamer;
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] l = new string[8];
        int[] n = new int[8];
        float[] f = new float[5];
        bool[] b = new bool[8];
        Jogos[] jogos = new Jogos[5];
        Jogador[] jogadores = new Jogador[3];

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("Cadastro do {0} Jogo", i + 1);
            Console.Write("Nome do Jogo: ");
            l[i] = Console.ReadLine();

            Console.Write("Nota do Jogo [0/100]: ");
            float input = float.Parse(Console.ReadLine());
            if (input <= 100 && input >= 0)
            {
                f[i] = input;
            }
            else
            {
                Console.WriteLine("Reinicie o Programa Nota Invalida");
                Console.ReadLine();
                break;
            }

            Console.Write("Data de Lançamento: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Vocé Joga esse Jogo [S/N]: ");
            string inputd = Console.ReadLine().ToUpper();
            if (inputd == "S")
            {
                b[i] = true;
            }
            else
            {
                b[i] = false;
            }

            jogos[i] = new Jogos(l[i], f[i], n[i], b[i]);
        }

        for (int i = 3; i < 5; i += 1)
        {
            Console.WriteLine("Cadastro do {0} Jogo", i + 1);
            Console.Write("Nome do Jogo: ");
            l[i] = Console.ReadLine();

            Console.Write("Nota do Jogo [0/100]: ");
            float input = float.Parse(Console.ReadLine());
            if (input >= 0 && input <= 100)
            {
                f[i] = input;
            }
            else
            {
                Console.WriteLine("Reinicie o Programa Nota Invalida");
                Console.ReadLine();
                break;
            }

            Console.Write("Data de Lançamento: ");
            n[i] = int.Parse(Console.ReadLine());

            jogos[i] = new Jogos(l[i], f[i], n[i]);
        }

        for (int i = 5; i < 8; i += 1)
        {
            Console.WriteLine("Cadastro do Jogador {0}", i - 4);
            Console.Write("Nome: ");
            l[i] = Console.ReadLine();

            Console.Write("Idade: ");
            n[i] = int.Parse(Console.ReadLine());

            Console.Write("Vocé é Gamer? [SIM/NAO]: ");
            string input = Console.ReadLine().ToUpper();
            if (input == "SIM")
            {
                b[i] = true;
            }
            else
            {
                b[i] = false;
            }

            jogadores[i - 5] = new Jogador(l[i], n[i], b[i]);
        }

        for (int i = 0; i < 5; i += 1)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Jogo {0}: {1}", i + 1, jogos[i].nome);
            Console.WriteLine("Nota do {0}: {1}", jogos[i].nome, jogos[i].nota);
            Console.WriteLine("Data de Lançamento: {0}", jogos[i].lançamento);
            if (jogos[i].jg == true)
            {
                Console.Write("Vocé Ja Jogou: Sim");
            }
            else if (jogos[i].jg == false)
            {
                Console.WriteLine("Vocé Ja Jogou: Não");
            }
            else
            {
                Console.WriteLine("---------------");
                continue;
            }
            Console.WriteLine("---------------");
        }

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Jogador {0}: {1}", i + 1, jogadores[i].nome);
            Console.WriteLine("Idade de {0}: {1}", jogadores[i].nome, jogadores[i].idade);
            if (jogadores[i].gamer == true)
            {
                Console.WriteLine("Sim vocé é Gamer {0}", jogadores[i].nome);
            }
            else
            {
                Console.WriteLine("Vocé Não é Gamer {0}", jogadores[i].nome);
            }
            Console.WriteLine("---------------");
        }
        Console.ReadLine();
    }
}