using System;

class Veiculo            // classe Pai
{
    public int rodas;
    public int velMax;
    public bool ligado;

    private void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        ligado = false;
    }
}

class Carro : Veiculo               // Classe Herdando a Classe PAi
{
    public string nome;
    public string cor;
    
    public Carro(string nome, string cor)
    {
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

internal class Principal
{
    public static void Main()
    {
        Carro c1 = new Carro("Hilux", "Vermelho");
        Console.WriteLine("{0}", c1.cor);
        Console.ReadLine();
    }
}