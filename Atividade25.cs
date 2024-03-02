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
        for (int n = 0; n < 10; n += 1)                   // a variavel aq n muda de valor so pq chamei a funsão 4x
        {
            Console.WriteLine("Hello World");
        }
        Console.ReadLine();
    }
}