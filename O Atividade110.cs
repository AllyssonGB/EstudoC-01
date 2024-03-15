using System;

public class Player
{
    private string nome;
    private int idade;
    private float dinheiro;

    public Player(string nome, int idade, float dinheiro)
    {
        this.nome = nome;
        this.idade = idade;
        this.dinheiro = dinheiro;
    }

    public string nome1
    {
        get
        {
            return nome;
        }
        set
        {
            this.nome = value;
        }
    }

    public int idade1
    {
        get
        {
            return idade;
        }
        set
        {
            this.idade = value;
        }
    }

    public float getDinheiro()
    {
        return dinheiro;
    }

    public void SetDinheiro(float dinheiro)
    {
        this.dinheiro = dinheiro;
    }
}

public class Jogador : Player
{
    protected int velocidade;

    public Jogador(string nome, int idade, float dinheiro, int velocidade) : base(nome, idade, dinheiro)
    {
        this.velocidade = velocidade;
    }

    public int velociade
    {
        get
        {
            return velocidade;
        }
        set
        {
            this.velocidade = value;
        }
    }
}

internal class Principal
{
    public static void Main(string[] args)
    {
        Player j1 = new Player("Allysson", 21, 564.65f);
        Jogador j2 = new Jogador("Lucas", 23, 634.65f, 500);

        Console.WriteLine("{0} Tem {1} Anos é tem R${2}", j1.nome1, j1.idade1, j1.getDinheiro());
        Console.WriteLine("{0} Tem {1} Anos é tem R${2} Com Velocidade de {3}", j2.nome1, j2.idade1, j2.getDinheiro(),j2.velociade);
        Console.ReadLine();
    }
}