using System;

abstract public class Automovel
{
    protected int VelMax, VelAtual;
    protected bool ligado;

    public Automovel()
    {
        ligado = false;
        VelAtual = 0;
    }

    abstract public void SetVelAtual(int mult);

    public int getVelAtual()
    {
        return VelAtual;
    }
}

public class Carro : Automovel
{
    public Carro()
    {
        VelMax = 120;
    }

    public void SetLigado()
    {
        ligado = true;
    }

    public override void SetVelAtual(int mult)
    {
        VelAtual += 10 * mult;
    }
}

internal class Principal
{
    public static void Main()
    {
        Carro c = new Carro();
        c.SetLigado();
        c.SetVelAtual(1);
        c.SetVelAtual(1);
        c.SetVelAtual(1);

        Console.WriteLine(c.getVelAtual());
        Console.ReadLine();
    }
}