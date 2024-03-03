using System;

public class Automovel
{
    public int ano = 0;
    public float valor = 0f;
    public string marca = "";
    public string tipo = "";
}

internal class Principal
{
    public static void Main()
    {
        Automovel veiculo1 = new Automovel();
        Automovel veiculo2 = new Automovel();

        veiculo1.ano = 2021;
        veiculo1.valor = 87999.99f;
        veiculo1.marca = "Toyota";
        veiculo1.tipo = "Carro";

        veiculo2.ano = 2024;
        veiculo2.valor = 148999.99f;
        veiculo2.marca = "Mercedes";
        veiculo2.tipo = "Caminhão";

        Console.WriteLine("Vocé Deseja Compra 1 {0} Da Marca {1} Por Apenas R${2} Fabricado no ano de {3}", veiculo1.tipo, veiculo1.marca, veiculo1.valor, veiculo1.ano);
        Console.WriteLine("Vocé Deseja Compra 1 {0} Da Marca {1} Por Apenas R${2} Fabricado no ano de {3}", veiculo2.tipo, veiculo2.marca, veiculo2.valor, veiculo2.ano);
        Console.ReadLine();

    }
}