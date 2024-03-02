using System;

internal class Principal
{
    public static void Main()
    {
        int v1, v2, r;
        Console.Write("Diga o Primeiro Valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Diga o Segundo Valor: ");
        v2 = int.Parse(Console.ReadLine());
        r = soma(v1,v2);

        Console.WriteLine("A Soma de {0} + {1} É Igual a {2}", v1, v2, r);
        Console.ReadLine();
    }



    //static void soma(int n1, int n2)                // Sem Retorno
    //{
    //    int n3 = n1 + n2;
    //    Console.WriteLine("A Soma de {0} + {1} É Igual a {2}", n1, n2, n3);
    //    Console.ReadLine();
    //}

    static int soma(int n1, int n2)                // Com Retorno
    { 
        int n3 = n1 + n2;
        return n3;
    }
}