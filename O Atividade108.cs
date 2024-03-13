using System;
using System.Collections.Generic;

internal class Principal
{
    public static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("Allysson");
        fila.Enqueue("Lucas");
        fila.Enqueue("Gilvan");
        fila.Enqueue("Andre");
        string v;

        try
        {
            Console.Write("Nome que voce deseja ver se esta na lista: ");
            v = Console.ReadLine();
        }catch(Exception e)
        {
            Console.WriteLine("Erro: {0}", e.Message);
            v = "Nulo";
        }

        if (fila.Contains(v))
        {
            Console.WriteLine("A Palavra {0} Èsta na Fila", v);
        }
        else
        {
            Console.WriteLine("A Palavra {0} Não Esta na Lista", v);
        }

        Console.WriteLine("Tam da Lista {0}", fila.Count());

        while (fila.Count() > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} Removido da Fila", fila.Dequeue());
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tam da Lista {0}", fila.Count());
        Console.ReadLine();
    }
}