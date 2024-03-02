using System;

internal class Privado
{
    public static void Main()
    {
        int n1 = 0;

        Console.Write("Digite o Dia da Semana (1/7): ");
        n1 = int.Parse(Console.ReadLine());



        switch (n1)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda");
                break;
            case 3:
                Console.WriteLine("Terça");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6:
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Nenhum Dia Correspondente");
                break;
        }
    }
}