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
        Console.ReadLine();
    }
}





internal class Principal
{
    public static void Main()
    {
        Carro c1 = new Carro("Honda", "XRE","Prata");

        //c1.marca = "Toyota";
        //c1.modelo = "Hilux";
        //c1.cor = "Azul";

        c1.info();
    }
}