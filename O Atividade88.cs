using System;

public class Soma
{
    public int soma(int n1,int n2)
    {
        return n1 + n2;
    }

    public int soma(int n1, int n2,int n3)
    {
        return n1 + n2 + n3;
    }

    public double soma(params double[] x)
    {
        double res = 0;
        for(int i = 0; i < x.Length; i++)
        {
            res += x[i];
        }
        return res;
    }
}

internal class Principal
{
    public static void Main()
    {
        Soma soma = new Soma();

        var res = soma.soma(5.5,5.5,4,5);
        Console.WriteLine(res);

        Console.ReadLine();
    }
}