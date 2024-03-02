using System;

internal class Privado
{
    public static void Main()
    {
        int n1;

        Console.Write("Digite um numero: ");
        n1 = int.Parse(Console.ReadLine());

        if(n1 > 10)
        {
            Console.WriteLine("Maior que 10");
        }
        else if(n1 == 10)
        {
            Console.WriteLine("Igual a 10");
        }
        else
        {
            Console.WriteLine("Menor que 10");
        }
    }
}