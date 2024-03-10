using System;

abstract public class Player
{
    protected string nome;
    protected int velocidade, idade;
    private bool vivo;

    abstract public void addVelocidade(int mult);

    public bool getVivo()
    {
        return vivo;
    }

    public bool setVivo(bool vivo)
    {
        this.vivo = vivo;
        return vivo;
    }
}

public class Jogador : Player
{
    public Jogador()
    {
        this.nome = "Allysson";
        this.velocidade = 0;
        this.idade = 21;
        setVivo(true);
    }

    override public void addVelocidade(int mult)
    {
        this.velocidade += 10 * mult;
    }

    public string getNome()
    {
        return this.nome;
    }

    public int getIdade()
    {
        return this.idade;
    }

    public int getVelocidade()
    {
        return this.velocidade;
    }
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador();
        j1.addVelocidade(1);
        j1.addVelocidade(5);

        Console.WriteLine("{0} Tem Idade de {1} é Velocidade de {2} é Esta Vivo?: {3}",j1.getNome(), j1.getIdade(), j1.getVelocidade(), j1.getVivo());
        Console.ReadLine();
    }
}