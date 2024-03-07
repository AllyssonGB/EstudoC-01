using System;
using System.Globalization;

public class Jogador                      // Classe Principal 
{
    public string nome;
    private int idade, energia;
    private float dinheiro;
    private bool vivo;

    public Jogador(string nome,int idade,int energia,float dinheiro,bool vivo)
    {
        this.nome = nome;
        this.idade = idade;
        this.energia = energia;
        this.dinheiro = dinheiro;
        this.vivo = vivo;
    }

    public int getIdade()
    {
        return idade;
    }
    public int getIenergia()
    {
        return energia;
    }
    public float getDinheiro()
    {
        return dinheiro;
    }
    public bool isVivo()
    {
        return vivo;
    }
}
// Fim da Classe Base Jogador

public class Volei : Jogador
{
    private int velocidade;
    public Volei(string nome, int idade, int energia, float dinheiro, bool vivo, int velocidade) : base(nome, idade, energia, dinheiro, vivo)
    {
        this.velocidade = velocidade;
    }

    public int getVelocidade()
    {
        return velocidade;
    }
}
// Fim da Classe Volei

public class Gamer : Volei
{
    private string tempodejogo;
    public Gamer(string nome, int idade,int energia, float dinheiro, bool vivo,int velocidade, string tempodejogo) : base(nome, idade,energia, dinheiro, vivo, velocidade)
    {
        this.tempodejogo = tempodejogo;
    }

    public string getTempoDeJogo()
    {
        return tempodejogo;
    }
}


internal class Principal
{
    public static void Main()
    {
        Gamer j1 = new Gamer("Allysson", 25, 60, 756.56f, true, 60, "87 Horas");         // pra testa todas posibilidades Criar cada 1 dos construtores
        Console.WriteLine(j1.nome);
        Console.WriteLine(j1.getIdade());
        Console.WriteLine(j1.getDinheiro());
        Console.WriteLine(j1.isVivo());
        Console.WriteLine(j1.getIenergia());
        Console.WriteLine(j1.getTempoDeJogo());
        Console.WriteLine(j1.getVelocidade());
        Console.ReadLine();

    }
}