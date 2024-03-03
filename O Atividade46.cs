using System;

public class Carro
{
    public int ano = 0;
    public int valor = 0;
    public string marca = "";

    public Carro(int ano1, int valor1, string marca1)
    {
        ano = ano1;
        valor = valor1;
        marca = marca1;
    }
}

internal class Principal
{
    public static void Main()
    {
        int ano10, ano20, ano30, valor10, valor20, valor30;
        string marca10, marca20, marca30;
        Carro carro1, carro2, carro3;

        Console.Write("Digite o Ano do Primeiro Carro: ");
        ano10 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Valor Desse Carro: ");
        valor10 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Nome Desse Carro: ");
        marca10 = Console.ReadLine();

        Console.Write("Digite o Ano do Segundo Carro: ");
        ano20 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Valor Desse Carro: ");
        valor20 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Nome Desse Carro: ");
        marca20 = Console.ReadLine();

        Console.Write("Digite o Ano do Primeiro Carro: ");
        ano30 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Valor Desse Carro: ");
        valor30 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Nome Desse Carro: ");
        marca30 = Console.ReadLine();

        carro1 = new Carro(ano10, valor10, marca10);
        carro2 = new Carro(ano20, valor20, marca20);
        carro3 = new Carro(ano30, valor30, marca30);

        Console.WriteLine("Carro de Ano {0} no Valor de {1} é Sua Marca é {2}", carro1.ano, carro1.valor, carro1.marca);
        Console.WriteLine("Carro de Ano {0} no Valor de {1} é Sua Marca é {2}", carro2.ano, carro2.valor, carro2.marca);
        Console.WriteLine("Carro de Ano {0} no Valor de {1} é Sua Marca é {2}", carro3.ano, carro3.valor, carro3.marca);
        Console.ReadLine();


    }
}