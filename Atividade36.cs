using System;

internal class Principal
{
    public static void Main()
    {
        float[] v = new float[6];
        string nome;
        
        Console.Write("Digite Sua Primeira Nota: ");
        v[0] = float.Parse(Console.ReadLine());

        Console.Write("Digite Sua Segunda Nota: ");
        v[1] = float.Parse(Console.ReadLine());

        Console.Write("Digite Sua Terceira Nota: ");
        v[2] = float.Parse(Console.ReadLine());

        Console.Write("Digite Sua Quarta Nota: ");
        v[3] = float.Parse(Console.ReadLine());

        Console.Write("Digite Seu Nome: ");
        nome = Console.ReadLine();

        v[4] = media(v[0], v[1], v[2], v[3]);
        v[5] = maior(v[0], v[1], v[2], v[3]);

        Console.WriteLine("{0} Sua Media Total foi de {1} É Sua Maior Nota foi {2}", nome, v[4], v[5]);
        Console.ReadLine();
    }

    public static float media(float n1, float n2, float n3, float n4)
    {
        float resultadomedia = (n1 + n2 + n3 + n4) / 4;
        return resultadomedia;
    }

    public static float maior(float n1, float n2, float n3, float n4)
    {
        float resultadomaior;
        if (n1 > n3 && n1 > n2 && n1 > n4)
        {
            resultadomaior = n1;
        }
        else if (n2 > n3 && n2 > n4)
        {
            resultadomaior = n2;
        }
        else if ( n3 > n4)
        {
            resultadomaior = n3;
        }
        else
        {
            resultadomaior = n4;
        }
        return resultadomaior;
    }
}