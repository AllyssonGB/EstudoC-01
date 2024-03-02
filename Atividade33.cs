using System;

internal class Principal
{
    public static void Main()
    {
        int n1, n2, n3, n4;

        Console.Write("Diga o Primeiro Numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Diga o Segundo Numero: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Diga o Terceiro Numero: ");
        n3 = int.Parse(Console.ReadLine());

        n4 = maior(n1, n2, n3);

        Console.WriteLine("Maior Numero Entre {0} {1} {2} é o {3}", n1, n2, n3, n4);
        Console.ReadLine();
    }

    public static int maior(int n1, int n2, int n3)
    {
        int resultado = 0;
        if(n1 > n2 && n1 > n3)
        {
            resultado = n1;
        }
        else if(n2 > n1 && n2 > n3) 
        {

            resultado = n2;
        }
        else
        {
            resultado = n3;
        }
        return resultado;
    }
}