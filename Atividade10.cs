using System;

internal class Privado
{
    public static void Main()
    {
        int idade1, idade2, idade3, idade4;
        string nome1, nome2, nome3, nome4;
        float media;

        Console.Write("Digite Seu Nome: ");
        nome1 = Console.ReadLine();

        Console.Write("Agora Digite Sua idade {0}: ", nome1);
        idade1 = int.Parse(Console.ReadLine());

        Console.Write("Digite Seu Nome: ");
        nome2 = Console.ReadLine();

        Console.Write("Agora Digite Sua idade {0}: ", nome2);
        idade2 = int.Parse(Console.ReadLine());

        Console.Write("Digite Seu Nome: ");
        nome3 = Console.ReadLine();

        Console.Write("Agora Digite Sua Idade {0}: ", nome3);
        idade3 = int.Parse(Console.ReadLine());

        Console.Write("Digite Seu Nome: ");
        nome4 = Console.ReadLine();

        Console.Write("Agora Digite Sua idade {0}: ", nome4);
        idade4 = int.Parse(Console.ReadLine());

        media = (idade1 + idade2 + idade3 + idade4) / 2;

        Console.WriteLine("{0} você tem {1} Anos",nome1, idade1);
        Console.WriteLine("{0} você tem {1} Anos",nome2, idade2);
        Console.WriteLine("{0} você tem {1} Anos",nome3, idade3);
        Console.WriteLine("{0} você tem {1} Anos",nome4, idade4);
        Console.WriteLine("A media da idade de todos é {0}", media);

    }
}