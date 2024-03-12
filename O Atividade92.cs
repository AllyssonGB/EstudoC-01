using System;

public class Mate
{
    public static double n = 5.50;

    public static int triplo(int n1)
    {
        return n1 * 3;
    }

}

internal class Principal
{
    public static void Main()
    {
        double n1 = Mate.n;

        Console.WriteLine("Triplo: {0}", Mate.triplo(5));
        Console.WriteLine("{0}", n1);
        Console.ReadLine();
    }
}