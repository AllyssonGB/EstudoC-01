using System;

internal class Principal
{
    public static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            Console.WriteLine("Qtde de Argumentos: {0}", args.Length);
        }
        else
        {
            Console.WriteLine("Sem Argumentos");
        }
    }
}