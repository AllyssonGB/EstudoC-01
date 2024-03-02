using System;

internal class Principal
{
    public static void Main()
    {
        int[] v = new int[3];

        Console.Write("Digite O primeiro Numero: ");
        v[0] = int.Parse(Console.ReadLine());

        Console.Write("Digite O Segundo Numero: ");
        v[1] = int.Parse(Console.ReadLine());

        v[2] = soma(v[0], v[1]);

        Console.WriteLine("A Soma Entre {0} é {1} é Igual a {2}", v[0], v[1], v[2]);
        Console.ReadLine();
    }

    static int soma(int n1, int n2)
    {
        int resultado = n1 + n2;
        return resultado;

    }
}