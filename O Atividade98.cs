using System;

public class Classe
{
    public static int div(int n1, int n2)
    {
        try
        {
            return n1 / n2;
        }catch (Exception e)
        {
            Console.WriteLine("Erro 2: {0}",e.Message);
            return 0;
        }
        
    }
}

internal class Principal
{
    public static void Main(string[] args)
    {
        int div = 0, n1 = 10 , n2 = 0;
        div = Classe.div(n1, n2);

        try
        {
            Console.WriteLine("{0} / {1} = {2}", n1, n2, div);
        }
        catch(Exception e)
        {
            Console.WriteLine("Erro: {0}",e.Message);
        }
        finally
        {
            Console.WriteLine("Concluido");
        }

        Console.ReadLine();
    }
}