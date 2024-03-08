using System;

abstract public class Jogador
{
    protected string nome;
    protected int passos, velocidade;
    
    public Jogador()
    {
        this.nome = "Allysson";
        this.passos = 0;
    }

    public int getPassos()
    {
        return passos;
    }

    abstract public void setPassos(int mult);
}

public class Aluno : Jogador
{
    public Aluno()
    {
        velocidade = 200;
    }

    public override void setPassos(int mult)
    {
        passos += 10 * mult;
    }
}

internal class Principal
{
    public static void Main()
    {
        Aluno a = new Aluno();
        a.setPassos(1);
        a.setPassos(1);
        a.setPassos(-1);
        a.setPassos(1);

        Console.WriteLine(a.getPassos());
        Console.ReadLine();
    }
}