using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca,string modelo,string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {
        Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}", this.marca, this.modelo, this.cor);
        Console.WriteLine("------------------------------------");
        Console.ReadLine();
    }
}





internal class Principal
{
    public static void Main()
    {
        Carro[] carros = new Carro[5];

        //c1.marca = "Toyota";
        //c1.modelo = "Hilux";
        //c1.cor = "Azul";

        carros[0].marca = "Honda";
        carros[0].modelo = "XRE300";
        carros[0].cor = "Verde";

        carros[1].marca = "Toyota";
        carros[1].modelo = "Hilux";
        carros[1].cor = "Preta";

        carros[2].marca = "Fiat";
        carros[2].modelo = "Fiat Touro";
        carros[2].cor = "Branco";

        carros[3].marca = "Ford";
        carros[3].modelo = "S10";
        carros[3].cor = "Azul";

        carros[4].marca = "Yamaha";
        carros[4].modelo = "Fazer";
        carros[4].cor = "Vermelho";

        carros[0].info();
        carros[1].info();
        carros[2].info();
        carros[3].info();
        carros[4].info();
    }
}