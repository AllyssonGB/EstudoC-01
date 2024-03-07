using System;

public class Automovel                             // Classe Base
{
    public string nome;
    private int rodas;
    private bool ligado;
    private string cor;


    public int roda(int rodas)
    {
        return this.rodas = rodas;
    }

    public bool ligar()
    {
        return ligado = true;
    }

    public bool desligar()
    {
        return ligado = false;
    }

    public string NovaCor(string cor)
    {
        return this.cor = cor;
    }
}
public class Carro : Automovel
{
    private int municao;
    public Carro(string nome)
    {
        this.nome = nome;
    }

    public int getmunicao(int municao)
    {
        return this.municao = municao;
    }

    public string getnome()
    {
        return this.nome;
    }
}

public class Combate : Carro
{
    public Combate(string nome):base(nome)
    {
        this.nome = nome;
    }
}





internal class Principal
{
    public static void Main()
    {
        Carro c1 = new Carro("Hilux");
        Combate c2 = new Combate("Tank");
        Console.WriteLine("Nome do Carro......: {0}", c1.nome);
        Console.WriteLine("Quantidade de Rodas: {0}", c1.roda(4));
        Console.WriteLine("Esta Ligado........: {0}", c1.desligar());
        Console.WriteLine("Cor do Carro.......: {0}", c1.NovaCor("Verde"));
        Console.WriteLine("-----------------------------");
        Console.ReadLine();

        Console.WriteLine("Nome do Carro......: {0}", c2.nome);
        Console.WriteLine("Quantidade de Rodas: {0}", c2.roda(12));
        Console.WriteLine("Esta Ligado........: {0}", c2.desligar());
        Console.WriteLine("Cor do Carro.......: {0}", c2.NovaCor("Vermelho"));
        Console.WriteLine("Quantidade de Balas: {0}", c2.getmunicao(76));
        Console.WriteLine("-----------------------------");
        Console.ReadLine();
    }
}