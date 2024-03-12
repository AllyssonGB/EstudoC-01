using System;
using System.Collections.Generic;

internal class Principal
{
    public static void Main(string[] args)
    {
        LinkedList<string> transp = new LinkedList<string>();
        //

        transp.AddFirst("Carro");
        transp.AddFirst("Motocicleta");
        transp.AddFirst("Navio");
        transp.AddFirst("Aviao");

        //

        transp.AddLast("Bicicleta");

        //

        LinkedListNode<string> no;
        no = transp.FindLast("Navio");

        transp.AddAfter(no, "Patinete");

        //

        foreach (string q in transp)
        {
            Console.WriteLine(q);
        }
        Console.ReadLine();

    }
}