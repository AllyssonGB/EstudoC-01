using System;

internal class Principal
{
    public static void Main()
    {
        int divid, divis, resto, resultado;
        divid = 15;
        divis = 2;
        resultado = divide(divid, divis,out resto);
        Console.WriteLine("Resultado de {0} / {1} = {2} é o Resto é {3}",divid,divis,resultado,resto);
        Console.ReadLine();


    }

    static int divide(int dividendo, int divisor, out int resto) // out e como se fosse um return pra retorna mais de 1 valor
    {
        int q;
        q = dividendo / divisor;
        resto = dividendo % divisor;
        return q;
    }
}