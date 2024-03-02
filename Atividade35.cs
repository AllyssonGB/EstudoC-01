using System;

internal class Principal
{
    public static void Main()
    {
        float n1, n2, n3, n4, media1, maior1;
        Console.Write("Diga Sua Primeira Nota: ");
        n1 = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Segunda Nota: ");
        n2 = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Terceira Nota: ");
        n3 = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Quarta Nota: ");
        n4 = float.Parse(Console.ReadLine());

        media1 = media(n1, n2, n3, n4);
        maior1 = maior(n1, n2, n3, n4);

        final(media1, maior1);
    }
    public static float media(float v1, float v2, float v3, float v4)
    {
        float media = (v1 + v2 + v3 + v4) / 4;
        return media;
    }
    public static float maior(float m1, float m2, float m3, float m4)
    {
        float resultado;
        if (m1 > m2 && m1 > m3 && m1 > m4)
        {
            resultado = m1;
        }
        else if (m2 > m3 && m2 > m4)
        {
            resultado = m2;
        }
        else if (m3 > m4)
        {
            resultado = m3;
        }
        else
        {
            resultado = m4;
        }
        return resultado;
    }

    public static void final(float media3, float valor3)
    {
        Console.WriteLine("Sua Media Foi {0} é Sua Maior Nota foi {1}", media3, valor3);
        Console.ReadLine();
    }

}