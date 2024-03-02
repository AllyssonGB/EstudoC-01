using System;

internal class Principal
{
    public static void Main()
    {
        float nota1, nota2, nota3, nota4, media;

        Console.Write("Diga Sua Primeira Nota: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Segunda Nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Terceira Nota: ");
        nota3 = float.Parse(Console.ReadLine());

        Console.Write("Diga Sua Quarta Nota: ");
        nota4 = float.Parse(Console.ReadLine());

        media = numero(nota1, nota2, nota3, nota4);
        resultado(media);

    }


    public static float numero(float n1, float n2, float n3, float n4)
    {
        float resultado = (n1 + n2 + n3 + n4) / 4;
        return resultado;
    } 


    public static void resultado(float meta)
    {
        if(meta > 8)
        {
            Console.WriteLine("Parabens voce Foi incrivel com a Nota {0}", meta);
            Console.ReadLine();
        }
        else if (meta >= 6)
        {
            Console.WriteLine("Parabens voce Foi Aprovado {0}", meta);
            Console.ReadLine();
        }
        else if (meta < 6)
        {
            Console.WriteLine("Voce Esta em Recuperação Nota: {0}", meta);
            Console.ReadLine();
        }
        else if(meta < 4)
        {
            Console.WriteLine("Reprovado !! Nota: {0}", meta);
            Console.ReadLine();
        }
    }

}