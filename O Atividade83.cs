using System;

public interface Teste
{
    public string getNome();
}

public interface TesteTwo
{
    public void SetNome(string nome);
}

public class Player : Teste, TesteTwo
{
    protected string nome;

    public Player()
    {
        this.nome = "Ricardo";
    }

    public string getNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string nm
    {
        get
        {
            return this.nome;
        }
        set
        {
            this.nome = value;
        }
    }
}

internal class Principal
{
    public static void Main()
    {
        Player j1 = new Player();

        j1.nm = "RICO";
        Console.WriteLine("{0} Jogador",j1.nm);
        Console.ReadLine();
    }
}