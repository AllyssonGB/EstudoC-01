using System;

internal class Private
{   
    enum DiasSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sábado};         // Criei 1 variavel dessa porem ela so pode receber esses valores
    public static void Main()
    {
        DiasSemana ds = (DiasSemana)3;            // Criando 1 Varivel Com um dos Valores a Cima Usando Indice 3

        Console.WriteLine(ds);
    }
}