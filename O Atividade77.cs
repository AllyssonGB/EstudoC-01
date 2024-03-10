using System;

public class Carro
{
    private int[] velocidade = new int[3] { 200, 550, 700 };

    public int this[int i]
    {
        get
        {
            return velocidade[i];
        }
        set
        {
            velocidade[i] = value;
        }
    }

    public Carro()
    {

    }
}

internal class Principal
{
    public static void Main()
    {
        Carro c1 = new Carro();
    
        Console.WriteLine("Velocidade: {0}", c1[2] = 0);
        Console.ReadLine();
    }
}