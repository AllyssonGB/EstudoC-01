using System;

internal class Principal
{
    public static void Main()
    {
        int[] v = new int[5];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite Um Numero: ");
            v[i] = int.Parse(Console.ReadLine());
        }
        v[4] = maior(v[0], v[1], v[2]);

        Console.WriteLine("Maior Entre {0} {1} {2} é {3}", v[0], v[1], v[2], v[4]);
        Console.ReadLine(); // Adicione os parênteses para chamar o método ReadLine
    }

    static int maior(int n1, int n2, int n3)
    {
        int maior;
        if (n1 > n2 && n1 > n3)
        {
            maior = n1;
        }
        else if (n2 > n1 && n2 > n3)
        {
            maior = n2;
        }
        else
        {
            maior = n3;
        }

        return maior;
    }
}
