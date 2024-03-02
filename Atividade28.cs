using System;

internal class Principal
{
    public static void Main()
    {
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);                 // se n tiver o (ref) ele n muda o varivavel num de valor
        Console.ReadLine();
    }

    static void dobrar(ref int n1)
    {
        n1 *= 2;
    }
}