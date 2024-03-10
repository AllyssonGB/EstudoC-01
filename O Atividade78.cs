using System;



public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}


public class Carro:Veiculo,Combate
{
    public bool ligado;
    private int municao;
    public Carro()
    {
        this.municao = 100;
    }

    public int this[int mult]
    {
        get
        {
            return this.municao;
        }
        set
        {
            this.municao = value;
        }
    }

    public void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        this.ligado = false;
    }

    public void info()
    {

    }

    public void disparar()
    {

    }
}





internal class Principal
{
    public static void Main()
    {
        Carro c1 = new Carro();
    }
}