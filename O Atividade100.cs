using System;
using System.Collections.Generic;

internal class Principal
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        // veiculos.Clear();

        // veiculos.Remove(20);

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count());
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count());
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count());

        int chave = 20;
        if(veiculos.ContainsKey(chave))
        {
            Console.WriteLine("A Chave: {0}", chave);
        }
        else
        {
            Console.WriteLine("Não Esta");
        }

        string chave1 = "Bicicleta";
        if (veiculos.ContainsValue(chave1))
        {
            Console.WriteLine("A Chave: {0}", chave1);
        }
        else
        {
            Console.WriteLine("Não Esta");
        }

        veiculos[15] = "Bicicleta";

        foreach (KeyValuePair<int, string> v in veiculos) 
        {
            Console.WriteLine(v);
            Console.WriteLine(v.Value);
            Console.WriteLine(v.Key);
        }



        Console.ReadLine();
    }
}