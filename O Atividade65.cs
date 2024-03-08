using System;

abstract public class Veiculo          // Classe Base Abstrata
{
    protected int VelMax;
    protected int VelAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        VelAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    public int getVelAtual()
    {
        return VelAtual;
    }

    abstract public void setVelAtual(int mult);
}

public class Carro : Veiculo
{
    public Carro()
    {
        VelMax = 120;
    }

    override public void setVelAtual(int mult)
    {
        VelAtual += 10 * mult;
    }
}

internal class Principal
{
    public static void Main()
    {
        Carro c = new Carro();
        c.setVelAtual(1);
        c.setVelAtual(1);
        c.setVelAtual(1);
        c.setVelAtual(1);
        c.setVelAtual(-1);
        c.setVelAtual(-1);

        Console.WriteLine(c.getVelAtual());
        Console.ReadLine();
    }
}