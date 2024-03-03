using System;

public class Jogador
{
    public int estamina = 100;
    public int idade = 0;
    public string nome = "";
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();


        j1.estamina = 60;
        j1.idade = 45;
        j1.nome = "Lucas";

        j2.estamina = 80;
        j2.idade = 26;
        j2.nome = "Andre";

        Console.WriteLine("Olá {0} Vocé Tem {1} De Estamina é Sua idade é {2}", j1.nome, j1.estamina, j1.idade);
        Console.WriteLine("Olá {0} Vocé Tem {1} De Estamina é Sua idade é {2}", j2.nome, j2.estamina, j2.idade);
        Console.ReadLine();
    }
}