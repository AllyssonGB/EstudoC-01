using System;
using System.Collections.Generic;

internal class Principal
{
    public static void Main(string[] args)
    {
        // string[] vs = {"Carro", "Moto", "Navio", "Avião"}
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Avião";
        if (veiculos.Contains(v))
        {
            Console.WriteLine("{0} Encontrado", v);
        }
        else
        {
            Console.WriteLine("Não Esta na Fila");
        }



        Console.WriteLine("Tamanho Fila: {0}", veiculos.Count());
        Console.ReadLine();

    }
}