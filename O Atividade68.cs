using System;

abstract public class Jogador
{
    protected string nome;
    protected int velocidade;
    protected bool vivo;

    public Jogador()
    {
        this.nome = "Allysson";
        this.velocidade = 0;
    }

    public int getVelocidade()
    {
        return velocidade;
    }

    abstract public void setVelocidade(int mult);
}

public class Aluno : Jogador
{
    public Aluno()
    {
        vivo = true;
    }
    
    override public void setVelocidade(int mult)
    {
        velocidade += 100 * mult;
    }
}

internal class Principal
{
    public static void Main()
    {
        Aluno a = new Aluno();
        a.setVelocidade(1);
        a.setVelocidade(1);
        a.setVelocidade(1);
        a.setVelocidade(1);
        a.setVelocidade(-1);

        Console.WriteLine(a.getVelocidade());
        Console.ReadLine();
    }
}