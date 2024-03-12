using System;

public class Galinha
{
    private string nome;
    private int ovo;

    public Galinha(string nome)
    {
        this.nome = nome;
        this.ovo = 0;
    }

    public Ovo BotarOvo()
    {
        this.ovo += 1;
        return new Ovo(nome,ovo);
    }
}

public class Ovo
{
    private int ovo;
    private string nome;
    public Ovo(string nome, int ovo)
    {
        this.nome = nome;
        this.ovo = ovo;
        Console.WriteLine("Ovo Criado {0}  -  {1}", this.ovo, this.nome);
    }
}

internal class Principal
{
    public static void Main()
    {
        Galinha g1 = new Galinha("Gilvan");
        Galinha g2 = new Galinha("Lucas");
        Galinha g3 = new Galinha("Ricardo");

        g1.BotarOvo();
        g1.BotarOvo();

        g2.BotarOvo();
        g2.BotarOvo();
        g2.BotarOvo();

        g3.BotarOvo();
        g3.BotarOvo();

        Console.ReadLine();
    }
}