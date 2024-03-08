using System;

public class Jogador
{
    private string nome;
    private int idade, energia;
    public Jogador(string nome, int idade, int energia)
    {
        this.nome = nome;
        this.idade = idade;
        this.energia = energia;
    }

    public string getNome()
    {
        return nome;
    }

    public int getIdade()
    {
        return idade;
    }

    public int getEnergia()
    {
        return energia;
    }
}
public class Joga : Jogador
{
    private float dinheiro;
    public Joga(string nome, int idade, int energia,float dinheiro): base(nome, idade, energia)
    {
        this.dinheiro = dinheiro;
    }
    public float getDinheiro()
    {
        return dinheiro;
    }
}

public class JogaTree : Joga
{
    private bool vivo;
    public JogaTree(string nome, int idade, int energia, float dinheiro,bool vivo):base(nome,idade, energia, dinheiro)
    {
        this.vivo = vivo;
    }
    public bool getVivo()
    {
        return vivo;
    }
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador("Allysson", 22, 100);
        Joga j2 = new Joga("Lucas", 23, 78, 565.23f);
        JogaTree j3 = new JogaTree("Andre", 23, 87, 1759.54f, true);

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("{0} Vocé Tem {1} Anos é {2}% De Energia",j1.getNome(),j1.getIdade(),j1.getEnergia());
        Console.WriteLine("{0} Vocé Tem {1} Anos é {2}% De Energia Saldo De R${3}",j2.getNome(),j2.getIdade(),j2.getEnergia(),j2.getDinheiro());
        Console.WriteLine("{0} Vocé Tem {1} Anos é {2}% De Energia Saldo De R${3} é Esta Vivo Esta {4}", j3.getNome(), j3.getIdade(), j3.getEnergia(), j3.getDinheiro(),j3.getVivo());
        Console.ReadLine();
    }
}