using System;

internal class Principal
{
    public static void Main()
    {
        int[] v = new int[3];
        Console.Write("Digite O Primeiro Valor: ");
        v[0] = int.Parse(Console.ReadLine());

        Console.Write("Digite O Segundo Valor: ");
        v[1] = int.Parse(Console.ReadLine());

        v[2] = soma(v[0], v[1]);

        Console.WriteLine("Resultado Entre {0} + {1} Fica Igual a {2}", v[0], v[1], v[2]);
        Console.ReadLine();
    }
    static int soma(int n1,int n2)
    {
        int valor = n1 + n2;
        return valor;
    }
}