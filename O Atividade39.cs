using System;

public class Jogador
{
    public int energia = 100;
    public float vida = 500;
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();
        Jogador j4 = new Jogador();

        j1.energia = 20;
        j1.vida = 255.5f;

        j2.vida = 460;
        j2.energia = 30;

        j3.vida = 220;
        j3.energia = 70;

        j4.vida = 246.5f;
        j4.energia = 100;

        Console.WriteLine("Jogador 1 Energia: {0} Vida: {1}", j1.energia, j1.vida);
        Console.WriteLine("Jogador 1 Energia: {0} Vida: {1}", j2.energia, j2.vida);
        Console.WriteLine("Jogador 1 Energia: {0} Vida: {1}", j3.energia, j3.vida);
        Console.WriteLine("Jogador 1 Energia: {0} Vida: {1}", j4.energia, j4.vida);
        Console.ReadLine();
    }
}