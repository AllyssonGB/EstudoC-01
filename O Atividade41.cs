using System;

public class Jogador
{
    public int folego = 1000;
    public int velocidade = 100;
    public string nome = "";
}

internal class Principal
{
    public static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.folego = 880;
        j1.velocidade = 60;
        j1.nome = "Lucas";

        j2.folego = 500;
        j2.velocidade = 30;
        j2.nome = "Andre";

        j3.folego = 950;
        j3.velocidade = 55;
        j3.nome = "Gilvan";

        Console.WriteLine("O Jogador {0} tem {1} de Folego é {2} de Velocidade", j1.nome, j1.folego, j1.velocidade);
        Console.WriteLine("O Jogador {0} tem {1} de Folego é {2} de Velocidade", j2.nome, j2.folego, j2.velocidade);
        Console.WriteLine("O Jogador {0} tem {1} de Folego é {2} de Velocidade", j3.nome, j3.folego, j3.velocidade);
        Console.ReadLine();


    }
}