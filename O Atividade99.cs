using System;

namespace Calc1                  // NameSpace Serve pra cria 2 classes ou funcçoes com mesmo nome mesmo q estejam em locais diferentes
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Não Pode ser 0");                 // Criando 1 Erro Pessonalizado
            }
            return bas * alt;
        }
    }
}

namespace Calc2                  // NameSpace Serve pra cria 2 classes ou funcçoes com mesmo nome mesmo q estejam em locais diferentes
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Não Pode ser 0");                 // Criando 1 Erro Pessonalizado
            }
            return bas * alt;
        }
    }
}

internal class Principal
{
    public static void Main(string[] args)
    {
        float area = 0;

        try                         // vai ver se vai da erro
        {
            area = Calc1.Area.Quad(10f, 5f);      // Como Escolhe a classe com o msm nome so q em namespace diferentes
            Console.WriteLine("Aréa do Quad: {0}", area);
        }
        catch (Exception e)                // se der erro
        {
            Console.WriteLine("Erro {0}", e.Message);
        }
        finally                          // vai acontecer se der erro ou n mais n e obrigatoria
        {
            Console.WriteLine("Fim Do Processo");
        }



        Console.ReadLine();
    }
}