using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvo;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo Botar()
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;

    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo Criado {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}

internal class Principal
{
    public static void Main()
    {
        Galinha g1 = new Galinha("Gilvan");
        Galinha g2 = new Galinha("Lucas");
        Galinha g3 = new Galinha("Ricardo");

        g1.Botar();
        g1.Botar();

        g2.Botar();
        g2.Botar();
        g2.Botar();

        g3.Botar();
        g3.Botar();

        Console.ReadLine();
    }
}
