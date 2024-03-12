using System;

public class Fat
{
    public int fato(int n)
    {
        int res = 0;
        if (n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n * fato(n - 1);
        }
        return res;
    }
}

internal class Principal
{
    public static void Main()
    {
        Fat soma = new Fat();

        var res = soma.fato(10);
        Console.WriteLine(res);

        Console.ReadLine();
    }
}