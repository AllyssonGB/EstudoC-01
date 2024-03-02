using System;

internal class Principal
{
    public static void Main()
    {
        int n1, n2, n3, n4, p;
        string m1, m2, m3, m4, s;

        Console.Write("Digite Seu Nome: ");
        m1 = Console.ReadLine();

        Console.Write("Digite Sua Nota (0/100): ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite Seu Nome: ");
        m2 = Console.ReadLine();

        Console.Write("Digite Sua Nota (0/100): ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite seu Nome: ");
        m3 = Console.ReadLine();

        Console.Write("Digite Sua nota (0/100): ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite Seu Nome: ");
        m4 = Console.ReadLine();

        Console.Write("Digite Sua nota (0/100: ");
        n4 = int.Parse(Console.ReadLine());

        if(n1 > n2 & n1 > n3 & n1 > n4)
        {
            p = n1;
            s = m1;
        }
        else if(n2 > n1 & n2 > n3 & n2 > n4)
        {
            p = n2;
            s = m2;
        }
        else if(n3 > n1 & n3 > n2 & n3 > n4)
        {
            p = n3;
            s = m3;
        }
        else
        {
            p = n4;
            s = m4;

        }

        Console.WriteLine("Parabens o Vencedor foi {0} com {1} .", s, p);
    }
}