using System;

struct Player
{
    public string nome, classe;
    public int poder, vida, velocidade;
    public float dinheiro;
    public bool vivo;

    public Player(string nome, string classe, int poder, int vida, int velocidade, float dinheiro, bool vivo)
    {
        this.nome = nome;
        this.classe = classe;
        this.poder = poder;
        this.velocidade = velocidade;
        this.vida = vida;
        this.dinheiro = dinheiro;
        this.vivo = vivo;
    }
}

public class BossOne
{
    protected string nome, classe;
    protected int poder, vida;
    protected bool vivo;

    public BossOne(string nome, string classe, int poder, int vida, bool vivo)
    {
        this.nome = nome;
        this.classe = classe;
        this.poder = poder;
        this.vida = vida;
        this.vivo = vivo;
    }

    public string getNome()
    {
        return nome;
    }

    public string getClasse()
    {
        return classe;
    }

    public int getPoder()
    {
        return poder;
    }

    public int getVida()
    {
        return vida;
    }

    public bool getVivo()
    {
        return vivo;
    }
}

public class BossTwo : BossOne
{
    protected int velocidade;

    public BossTwo(string nome, string classe, int poder, int vida, bool vivo, int velocidade) : base(nome, classe, poder, vida, vivo)
    {
        this.velocidade = velocidade;
    }

    public int getVelocidade()
    {
        return velocidade;
    }
}

public class BossTree : BossTwo
{
    protected bool instakill;

    public BossTree(string nome, string classe, int poder, int vida, bool vivo, int velocidade, bool instakill) : base(nome, classe, poder, vida, vivo, velocidade)
    {
        this.instakill = false;
    }

    public bool getInstakill()
    {
        return instakill;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void setClasse(string classe)
    {
        this.classe = classe;
    }

    public void setPoder(int poder)
    {
        this.poder = poder;
    }

    public void setVida(int vida)
    {
        this.vida = vida;
    }

    public void setVivo(bool vivo)
    {
        this.vivo = vivo;
    }

    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public void setInstakill(bool instakill)
    {
        this.instakill = instakill;
    }
}



internal class Principal
{
    public static void Main()
    {
        string[] letra = new string[10];
        int[] inteiro = new int[10];
        float[] flutuante = new float[10];
        bool[] bole = new bool[3];                           // Lembra de Apaga no Final Variaveis que nao forem usadas

        // Criação Bosses
        BossOne boss1 = new BossOne("World Devourer", "TITAN", 2700, 20000, true);
        BossTwo Boss2 = new BossTwo("Wall of Flesh", "DEMON", 13800, 87000, true, 5500);
        BossTree boss3 = new BossTree("Supreme Calamitas", "GOD", 43000, 327000, true, 14500, false);
        // Fim Bosses
        Player jogador = new Player("Nulo", "Nulo", 0, 0, 0, 0, true);
    }
}

// nao finalizado