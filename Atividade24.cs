using System;

internal class Principal
{
    public static void Main()
    {
        Hello();
        Hello();
        Hello();
        Hello();
    }
    static void Hello()
    {
        Console.WriteLine("Hello World");
        Console.ReadLine();
    }
}