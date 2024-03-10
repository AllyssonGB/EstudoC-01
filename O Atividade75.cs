using System;

public class Carro
{
    private int Velocidade;

    public int vel
    {
        get
        {
            return Velocidade;
        }
        set
        {
            Velocidade = value;
        }
    }

    public Carro()
    {
        vel = 230;
    }
}

internal class Principal
{
    public static void Main()
    {
        Carro c1 = new Carro();

        c1.vel = 780;
        Console.WriteLine("Velocidade: {0}", c1.vel);
        Console.ReadLine();
    }
}