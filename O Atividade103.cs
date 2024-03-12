using System;
using System.Collections.Generic;

internal class Principal
{
    public static void Main(string[] args)
    {
        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Hilux");
        carros.Add("Focus");
        carros.Add("Argo");

        carros2.AddRange(carros);

        // carros.Clear();

        if (carros.Contains("Golf"))
        {
            Console.WriteLine("Esta na Lista");
        }
        else
        {
            Console.WriteLine("Não Encontrado");
        }

        foreach(string c in carros2)
        {
            Console.WriteLine("Carro: {0}", c);
        }                                            

        Console.ReadLine();
    }
}