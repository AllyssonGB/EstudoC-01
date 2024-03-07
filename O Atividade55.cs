public class Gamer
{
    public string nome;
    public float nota;
    public int lançamento;

    public Gamer(string nome, float nota, int lançamento)
    {
        this.nome = nome;
        this.nota = nota;
        this.lançamento = lançamento;
    }

    public Gamer(string nome, int lançamento)
    {
        this.nome = nome;
        this.nota = 10;
        this.lançamento = lançamento;
    }

    public void info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(nota);
        Console.WriteLine(lançamento);
        Console.WriteLine("-----------------");
    }
}

internal class Principal
{
    public static void Main()
    {
        Gamer j1 = new Gamer("Resident Evil 4 Remake", 9, 2023);
        Gamer j2 = new Gamer("Shadow Of The Colossus", 7, 2020);
        Gamer j3 = new Gamer("God Of War", 2018);

        j1.info();
        j2.info();
        j3.info();
        Console.ReadLine();
    }
}