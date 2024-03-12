using System;


internal class Principal
{
    public static void Main(string[] args)
    {
        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0;

        try
        {
            res = n1 / n2;
        }
        catch
        {
            Console.WriteLine("Erro");
        }
      
        

        Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        Console.ReadLine();
    }
}