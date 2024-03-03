using System;

public class Carro
{
    public int Ano = 0;
    public string Marca = "";
}

internal class Principal
{
    public static void Main()
    {
        Carro hilux = new Carro();
        Carro Ford = new Carro();
        Carro Fiat = new Carro();

        hilux.Ano = 2024;
        hilux.Marca = "Toyota";

        Ford.Ano = 2022;
        Ford.Marca = "Ford";

        Fiat.Ano = 2023;
        Fiat.Marca = "Fiat";

        Console.WriteLine("Carro de Ano {0} é Marca {1}", hilux.Ano, hilux.Marca);
        Console.WriteLine("Carro de Ano {0} é Marca {1}", Ford.Ano, Ford.Marca);
        Console.WriteLine("Carro de Ano {0} é Marca {1}", Fiat.Ano, Fiat.Marca);
        Console.ReadLine();

    }
}