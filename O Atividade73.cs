using System;

abstract public class Automovel
{
    protected string marca;
    protected int valor, velocidade, velocidadetwo;

    abstract public void addVelocidade(int mult);
    abstract public void addVelocidadeTwo(int mult);

    public void setMarca(string marca)
    {
        this.marca = marca;
    }

    public void setValor(int valor)
    {
        this.valor = valor;
    }

    public string getMarca()
    {
        return this.marca;
    }

    public int getValor()
    {
        return this.valor;
    }

    public int getVelocidade()
    {
        return this.velocidade;
    }

    public int getVelocidadeTwo()
    {
        return this.velocidadetwo;
    }
}

public class Carro : Automovel
{
    public Carro(string marca,int valor)
    {
        this.marca = marca;
        this.valor = valor;
        this.velocidade = 0;
        this.velocidadetwo = 0;
    }

    override public void addVelocidade(int mult)
    {
        this.velocidade += mult * 10;
    }

    override public void addVelocidadeTwo(int mult)
    {
        this.velocidadetwo += mult * 10;
    }
}

internal class Principal
{
    public static void Main()
    {

        Carro c1 = new Carro("Nulo" ,0);
        Console.Write("Digite a Marca do Carro: ");
        c1.setMarca(Console.ReadLine());
        Console.Write("Digite o Valor do Carro: ");
        c1.setValor(int.Parse(Console.ReadLine()));

        c1.addVelocidade(5);
        c1.addVelocidadeTwo(2);

        Console.WriteLine("Carro da Marca {0} é Valor de R${1}\nVelocidade: {2}\nVelocidadeTwo: {3}",c1.getMarca(), c1.getValor(), c1.getVelocidade(), c1.getVelocidadeTwo());
        Console.ReadLine();
        
    }
}