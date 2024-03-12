using System;

public class Galinha
{
    private string nomeg;
    private int numovo;

    public Galinha(string nomeg)
    {
        this.nomeg = nomeg;
        this.numovo = 0;
    }

    public Ovo botar()
    {
        this.numovo++;
        return new Ovo(nomeg, numovo);
    }
}

public class Ovo
{
    private string nomeg;
    private int numovo;

    public Ovo(string nomeg, int numovo)
    {
        this.nomeg=nomeg;
        this.numovo=numovo;
        Console.WriteLine("Ovo {0}  -  {1}", this.numovo, this.nomeg);
    }
}

internal class Principal
{
    public static void Main()
    {
        Galinha g1 = new Galinha("Gilvan");
        Galinha g2 = new Galinha("Lucas");
        Galinha g3 = new Galinha("Ricardo");

        g1.botar();
        g1.botar();

        g2.botar();
        g2.botar();
        g2.botar();

        g3.botar();
        g3.botar();

        Console.ReadLine();
    }
}