using System;

public class Jogador
{
    private string nome;
    private int energia, idade;

    public Jogador(string nome, int energia, int idade)
    {
        this.nome = nome;
        this.energia = energia;
        this.idade = idade;
    }

    public string getNome()
    {
        return nome;
    }

    public int getEnergia()
    {
        return energia;
    }
    public int getIdade()
    {
        return idade;
    }
}

public class Aluno : Jogador
{
    private int velocidade;
    public Aluno(string nome, int energia, int idade, int velocidade) : base(nome, energia, idade)
    {
        this.velocidade = velocidade;
    }

    public int getVelocidade()
    {
        return velocidade;
    }
}

public class Pessoa : Aluno
{
    private float dinheiro;
    public Pessoa(string nome, int energia, int idade, int velocidade, float dinheiro) : base(nome, energia, idade, velocidade)
    {
        this.dinheiro = dinheiro;
    }

    public float getDinheiro()
    {
        return dinheiro;
    }
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador("Lucas", 100, 21);
        Aluno j2 = new Aluno("Allysson", 87, 22, 500);
        Pessoa j3 = new Pessoa("Andre", 65, 27, 360, 2453.45f);

        Console.WriteLine("{0} Com Energia de {1} é {2} Anos",j1.getNome(),j1.getEnergia(),j1.getIdade());
        Console.WriteLine("{0} Com Energia de {1} é {2} Anos {3} De Velocidade",j2.getNome(), j2.getEnergia(), j2.getIdade(),j2.getVelocidade());
        Console.WriteLine("{0} Com Energia de {1} é {2} Anos {3} De Velocidade Com Apenas R${4}",j3.getNome(), j3.getEnergia(), j3.getIdade(), j3.getVelocidade(),j3.getDinheiro());
        Console.ReadLine();
    }
}