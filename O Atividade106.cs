using System;
using System.Collections.Generic;

internal class Principal
{
    public static void Main(string[] args)
    {
        // string[] vs = {"Carro", "Moto", "Navio", "Avião"}
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); // add ao final da vila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Avião";              
        if (veiculos.Contains(v))              // Ver se o V(aviao) esta na lista
        {
            Console.WriteLine("{0} Encontrado", v);
        }
        else
        {
            Console.WriteLine("Não Esta na Fila");
        }

        // veiculos.Clear();                    Limpa Fila

        // Console.WriteLine("Primeiro Veiculo: {0}", veiculos.Dequeue());          // retorna o primeiro da fila e remove ele da fila
        // Console.WriteLine("Primeiro Veiculo: {0}", veiculos.Dequeue());
        //Console.WriteLine("Primeiro Veiculo: {0}", veiculos.Peek());                // retorna o primeiro da fila mas n remove
         
        
        while(veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());                  // imprimindo e removendo itens da fila com o Dequeue
        }

        Console.WriteLine("Tamanho Fila: {0}", veiculos.Count());             // retorna tamanho da fila
        Console.ReadLine();

    }
}