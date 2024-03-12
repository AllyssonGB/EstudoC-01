using System;
using System.Runtime.Serialization.Formatters;

class Calc
{
    public int soma(int n1,int n2)
    {
        return n1 + n2;
    }

    public int soma(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }
    public int soma(int n1, int n2, int n3,int n4)
    {
        return n1 + n2 + n3 + n4;
    }

    public float soma(float n1, float n2)
    {
        return n1 + n2;
    }

    public double soma(params double[] d)
    {
        double s = 0;
        for (int i = 0;i<d.Length;i++)
        {
            s += d[i];
        }
        return s;
    }
}

internal class Principal
{
    public static void Main()
    {
        Calc calc = new Calc();

        var res = calc.soma(10.5, 10.5, 10.5, 10.5, 10.5, 10.5, 10.5, 10.5);

        Console.WriteLine(res);
        Console.ReadLine();
    }
}