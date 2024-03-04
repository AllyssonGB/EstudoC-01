using System;

public class Automovel
{
    public string tipo, marca;
    public int rodas, ano;
    public float valor, km;

    public Automovel(string n1,string n2,int n3,int n4,float valor1,float km1)
    {
        tipo = n1;
        marca = n2;
        rodas = n3;
        ano = n4;
        valor = valor1;
        km = km1;
    }

    ~Automovel(){
        Console.WriteLine("Destruido");
        Console.ReadLine();
    }
}

internal class Principal
{
    public static void Main()
    {
        string[] s = new string[8];
        int[] a = new int[8];
        float[] f = new float[8];
        Automovel[] automoveis = new Automovel[4];

        for(int i = 0; i < 4; i += 1)
        {
            Console.WriteLine("Cadastro do Veiculo {0}", i + 1);
            Console.Write("Qual o Tipo do Seu Carro (Caminhão , Carro, Moto ,ETC): ");
            s[i] = Console.ReadLine();

            Console.Write("Qual a Marca do Seu Veiculo: ");
            s[i + 1] = Console.ReadLine();

            Console.Write("Quantas Rodas Tem nesse Veiculo: ");
            a[i] = int.Parse(Console.ReadLine());

            Console.Write("Qual o Ano de Fabricação do Veiculo: ");
            a[i + 1] = int.Parse(Console.ReadLine());

            Console.Write("Qual o Valor do Seu Veiculo: ");
            f[i] = float.Parse(Console.ReadLine());

            Console.Write("Quantos KM o Seu Carro ja Rodou Exemplo: [12,500]: ");
            f[i + 1] = float.Parse(Console.ReadLine());

            automoveis[i] = new Automovel(s[i], s[i + 1], a[i], a[i + 1], f[i], f[i + 1]);
        }

        for (int i = 0; i < 4; i += 1)
        {
            Console.WriteLine("Automovel do Tipo: {0}\nMarca: {1}\nRodas: {2}\nFabricação: {3}\nPreço do Veiculo: {4}\nKM Rodados: {5}"
                , automoveis[i].tipo, automoveis[i].marca, automoveis[i].rodas, automoveis[i].ano, automoveis[i].valor, automoveis[i].km);
        }
        Console.ReadLine();
    }
}