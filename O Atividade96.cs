using System;

internal class Principal
{
    public static void Main(string[] args)
    {
        int n1, n2, res;

        n1 = 10;
        n2 = 0;
        try
        {
            Console.Write("Digite um Numero: ");
            n2 = int.Parse(Console.ReadLine());
        }catch(Exception e)
        {
            Console.WriteLine("Erro Encontrado: {0}", e.Message);
        }
        
        try
        {
            res = n1 / n2;
            Console.WriteLine("{0} / {1} = {2}", n1, n2, res); 
        }catch(Exception e)
        {
            Console.WriteLine("Erro Encontrado: {0}", e.Message);
        }
        Console.ReadLine();
    } 
}