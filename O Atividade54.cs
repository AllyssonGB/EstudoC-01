using System;

public class Jogador
{
    public string nome;
    public int idade;
    public bool vivo;

    public Jogador(string nome, int idade, bool vivo)
    {
        this.nome = nome;
        this.idade = idade;
        this.vivo = vivo;
    }

    public Jogador(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
        this.vivo = true;
    }

    public void info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(vivo);
        Console.WriteLine("---------------------");
    }
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador("Andre", 21, false);
        Jogador j2 = new Jogador("Gilvan", 23, true);
        Jogador j3 = new Jogador("Lucas", 26, false);
        Jogador j4 = new Jogador("Rick", 26);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
        Console.ReadLine();
    }
}