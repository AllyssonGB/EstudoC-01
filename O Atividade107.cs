using System;
using System.Collections.Generic;
using System.Diagnostics;

internal class Principal
{
    public static void Main(string[] args)
    {
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Ford");
        veiculos.Enqueue("Hilux");
        veiculos.Enqueue("Fiat");
        veiculos.Enqueue("Ferrari");
        veiculos.Enqueue("Lamborguine");

        string v = "Ferrari";
        if (veiculos.Contains(v))
        {
            Console.WriteLine("Veiculo {0} Esta na Lista", v);
        }
        else
        {
            Console.WriteLine("Veiculo Nao Esta na Lista");
        }

        //Console.WriteLine("Veiculo Removido {0}", veiculos.Dequeue());
        //Console.WriteLine("Veiculo Removido {0}", veiculos.Dequeue());
        //Console.WriteLine("Veiculo Removido {0}", veiculos.Dequeue());

        //Console.WriteLine("Mostrando Veiculo {0}", veiculos.Peek());


        while(veiculos.Count > 0)
        {
            Console.WriteLine("Veiculo Removido {0}", veiculos.Dequeue());
        }



        Console.WriteLine("Tamanho da Fila: {0}", veiculos.Count());
        Console.ReadLine();

    }
}