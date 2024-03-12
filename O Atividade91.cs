using System;

public class Mat
{
    public static double pi = 3.14;


    public static int dobro(int n)
    {
        return n * 2;
    }
}


internal class Principal
{
    public static void Main()
    {
        double vpi = Mat.pi;
        int num = 10;

        Console.WriteLine("{0} Dobro", Mat.dobro(num));
        Console.ReadLine();
    }
}