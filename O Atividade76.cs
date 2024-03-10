using System;


class Carro
{
    private int[] VelMax = new int[5] { 10, 20, 30, 40, 50 };

    public int this[int i]
    {
        get
        {
            return VelMax[i];
        }
        set
        {
            if (value < 0)
            {
                VelMax[i] = 0;
            }
            else if (value > 300)
            {
                VelMax[i] = 300;
            }
            else
            {
                VelMax[i] = value;
            }
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

        Console.WriteLine("Velocidade: {0}", c1[2]);
        Console.ReadLine();
    }
}