using System;

internal class Principal
{
    public static void Main()
    {
        int n1, n2, n3, soma, maior = 0;

        Console.Write("Diga o Primeiro Numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Diga o Segundo Numero: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Diga o Terceiro Numero: ");
        n3 = int.Parse(Console.ReadLine());

        soma = n1 + n2 + n3;

        if(n1 > n2 && n1 > n3)
        {
            maior = n1;
        }
        else if(n2 > n1 && n2 > n3)
        {
            maior = n2;
        }
        else if(n3 > n2 && n3 > n1)
        {
            maior = n3;
        }
        else
        {
            Console.WriteLine("Erro no Sistema!!!");
        }

        Console.WriteLine("O Maior Numero Entre {0} {1} {2} é {3}", n1, n2, n3, maior);

        


    }
}