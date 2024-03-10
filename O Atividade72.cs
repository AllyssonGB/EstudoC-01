using System;

abstract public class Player
{
    protected string nome;
    protected int velocidade, idade;
    private float dinheiro;
    private bool vivo;

    abstract public string getNome();
    abstract public int getVelocidade();
    abstract public int getIdade();
    abstract public void addVelocidade(int mult);

    public float setDinheiro(float dinheiro)
    {
        this.dinheiro = dinheiro;
        return this.dinheiro;
    }

    public bool setVivo(bool vivo)
    {
        this.vivo = vivo;
        return this.vivo;
    }
    
    public float getDinheiro()
    {
        return this.dinheiro;
    }

    public bool getVivo()
    {
        return this.vivo;
    }
}

public class Jogador : Player
{
    public Jogador()
    {
        this.nome = "Allysson";
        this.velocidade = 0;
        this.idade = 21;
        this.setDinheiro(512.76f);
        this.setVivo(true);
    }

    public override int getVelocidade()
    {
        return this.velocidade;
    }

    public override string getNome()
    {
        return this.nome;
    }

    public override int getIdade()
    {
        return this.idade;
    }

    public override void addVelocidade(int mult)
    {
        this.velocidade += 10 * mult;
    }
}

public class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador();
        j1.addVelocidade(1);
        j1.addVelocidade(1);
        j1.addVelocidade(1);
        j1.addVelocidade(1);

        Console.WriteLine("{0} Tem R${1} é tem de idade {2} Correndo na Velocidade de {3} é ainda esta vivo?: {4}", j1.getNome(), j1.getDinheiro(), j1.getIdade()
            , j1.getVelocidade(), j1.getVivo());
        Console.ReadLine();
    }
}