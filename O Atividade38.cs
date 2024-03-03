using System;


public class Jogador
{
    public int energia = 100;
    public bool vivo = true;

}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 20;
        j2.energia = 50;
        j3.energia = 80;


        Console.WriteLine("Energia do Jogador 1: {0}",j1.energia);
        Console.WriteLine("Energia do Jogador 2: {0}",j2.energia);
        Console.WriteLine("Energia do Jogador 3: {0}",j3.energia);
        Console.ReadLine();

    }
}