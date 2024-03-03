using System;

public class Carro
{
    public string marca;
    public int ano;
    public float km;
    
    public Carro(string marca1, int ano1, float km1)
    {
        marca = marca1;
        ano = ano1;
        km = km1;
    }
}

internal class Principal
{
    public static void Main()
    {
        float[] km = new float[3];
        int[] ano = new int[3];
        string[] marca = new string[3];
        Carro[] carros = new Carro[3];

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("Cadastro Carro {0}", i + 1);
            Console.Write("Diga a Marca do Carro: ");
            marca[i] = Console.ReadLine();

            Console.Write("Diga Qual Ano do Carro: ");
            ano[i] = int.Parse(Console.ReadLine());

            Console.Write("Diga Quantos km Rodados Ex. 10,50: ");
            km[i] = float.Parse(Console.ReadLine());

            carros[i] = new Carro(marca[i], ano[i], km[i]);
        }

        for (int i = 0; i < 3; i += 1)
        {
            Console.WriteLine("Carro de Marca {0} Fabricado no Ano de {1} Com {2} KM Rodados", carros[i].marca, carros[i].ano, carros[i].km);
        }
        Console.ReadLine();
    }
}