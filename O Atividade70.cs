using System;

abstract public class Jogador
{
    protected string nome;
    protected int velocidade;
    protected float dinheiro;

    abstract public void addVelocidade(int mult);
}

public class Aluno : Jogador
{
    public Aluno()
    {
        this.nome = "Allysson";
        this.dinheiro = 6700;
        this.velocidade = 0;
    }

    public string getNome()
    {
        return this.nome;
    }

    public float getDinheiro()
    {
        return this.dinheiro;
    }

    public int getVelocidade()
    {
        return this.velocidade;
    }

    override public void addVelocidade(int mult)
    {
        velocidade += 10 * mult;
    }
}

internal class Principal
{
    public static void Main()
    {
        Aluno a = new Aluno();
        a.addVelocidade(1);
        a.addVelocidade(1);
        a.addVelocidade(1);
        a.addVelocidade(1);
        a.addVelocidade(1);
        a.addVelocidade(-1);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0} Tem R${1} é Tem Velocidade de {2}",a.getNome(),a.getDinheiro(),a.getVelocidade());
        Console.ReadLine();
    }
}