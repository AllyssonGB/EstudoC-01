using System;


public class Jogador
{
    public int energia;
    public bool vivo;

    public string nome;

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador("Lucas");
        Jogador j2 = new Jogador("Andre");
        Jogador j3 = new Jogador("Allysson");

        j1.energia = 20;
        j2.energia = 50;
        j3.energia = 80;

        Console.WriteLine("Nome do Jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do Jogador 2: {0}", j2.nome);
        Console.WriteLine("Nome do Jogador 3: {0}", j3.nome);
        Console.ReadLine();

    }
}