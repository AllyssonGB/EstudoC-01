using System;

internal class Privado
{
    public static void Main()
    {
        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro..........:{0,15:p}", lucro);
        Console.WriteLine("Valor de Venda.:{0,15:c}", valorVenda);
    }
}