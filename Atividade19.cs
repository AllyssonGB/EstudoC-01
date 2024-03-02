using System;

internal class Principal
{
    public static void Main()
    {
        int[] v = {5, 0, 0};

        for (v[0] = 1; v[0] < 11; v[0]+=1)
        {
            Console.WriteLine(v[0]);
        }
    }
}
