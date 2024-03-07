using System;

class Jogador
{
    private int energia;
    private string nome;

    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia()                  // Criar metodos de Retorno pra Private
    {
        return energia;
    }

    public string getNome()                // Criar metodos de Retorno pra Private
    {
        return nome;
    }

    public void setEnergia(int e)
    {
        if ( e < 0)
        {
            if (energia + e < 0)
            {
                energia = 0;
            }                                    // Menos com Menos é + toma cuidado
            else
            {
                energia += e;
            }
            
        }
        else if(e > energia)
        {
            if (energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
            
        }
    }
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador("Bruno");
        j1.setEnergia(-100);
        j1.setEnergia(34);
        Console.WriteLine("{0}",j1.getNome()); // Ai aqui tem q pedir o retorno vindo do metodo
        Console.WriteLine("{0}",j1.getEnergia());
        Console.ReadLine();
    }
}