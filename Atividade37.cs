using System;

internal class Principal
{
    public static void Main()
    {
        float[] v = new float[6];
        string nome;

        Console.Write("Diga o Seu Nome: ");
        nome = Console.ReadLine();

        Console.Write("Diga Sua Primeira Nota: ");
        v[0] = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Segunda Nota: ");
        v[1] = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Terceira Nota: ");
        v[2] = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Quarta Nota: ");
        v[3] = float.Parse(Console.ReadLine());

        v[4] = media(v[0], v[1], v[2], v[3]);
        v[5] = maior(v[0], v[1], v[2], v[3]);

        final(v[4], v[5]);
    }

    public static float media(float n1,float n2,float n3,float n4)
    {
        float resultadomedia = (n1 + n2 + n3 + n4) / 4;
        return resultadomedia;
    }

    public static float maior(float n1, float n2, float n3, float n4)
    {
        float resultadomaior;

        if(n1 > n2 && n1 > n3 && n1 > n4)
        {
            resultadomaior = n1;
        }
        else if(n2 > n3 && n2 > n4)
        {
            resultadomaior = n2;
        }
        else if(n3 > n4)
        {
            resultadomaior = n3;
        }
        else
        {
            resultadomaior = n4;
        }

        return resultadomaior;
    }

    public static void final(float n1, float n2)
    {

        Console.WriteLine("Sua Media foi de {0} é a sua nota maior no semestre foi de {1}", n1, n2);
        Console.ReadLine();

    }
}