using System;

abstract public class Player
{
    protected string nome;
    protected int velocidade;
    protected bool vivo;

    public Player(string nome)
    {
        this.vivo = false;
        this.nome = nome;
        this.velocidade = 0;
    }

    public int getVelocidade()
    {
        return velocidade;
    }

    public string getNome()
    {
        return nome;
    }

    abstract public void setVelocidade(int mult);
}

public class Jogador : Player
{
    public Jogador(string nome):base(nome) 
    {
        this.vivo = true;
    }

    override public void setVelocidade(int mult)
    {
        velocidade += 10 * mult;
    }
}

internal class Principal
{
    public static void Main()
    {
        Console.Write("Seu Nome: ");
        string nome = Console.ReadLine();
        Jogador j1 = new Jogador(nome);
        string loop = "";
        while(loop != "SAIR")
        {
           
        Console.WriteLine("Programa Finalizado Velocidade Maximo {0}", j1.getVelocidade());
        j1.setVelocidade(1);
        loop = Console.ReadLine().ToUpper();
        }
        Console.WriteLine("Velocidade Atual {0} Jogador {1}", j1.getVelocidade(), j1.getNome());
        Console.ReadLine();
    }
}