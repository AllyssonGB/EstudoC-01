using System;
using System.Collections.Generic;
using System.Threading;

public class Player
{
    public string nome, classe;
    public int velocidade, energia, vida, poder, ptvida, ptenergia, vidamax, energiamax;
    public double dinheiro;
    public bool vivo;

    public Player(string nome, string classe, int velocidade, int energia, int vida, int poder, double dinheiro, bool vivo, int ptvida, int ptenergia, int vidamax, int energiamax)
    {
        this.nome = nome;
        this.classe = classe;
        this.velocidade = velocidade;
        this.energia = energia;
        this.vida = vida;
        this.poder = poder;
        this.dinheiro = dinheiro;
        this.vivo = vivo;
        this.ptvida = ptvida;
        this.ptenergia = ptenergia;
        this.energiamax = energiamax;
        this.vidamax = vidamax;
    }
}

public class BossOne
{
    protected string nome, classe;
    protected int vida, poder;
    protected bool vivo;

    public BossOne(string nome, string classe, int vida, int poder, bool vivo)
    {
        this.nome = nome;
        this.classe = classe;
        this.vida = vida;
        this.poder = poder;
        this.vivo = vivo;
    }

    public string Pnome
    {
        get
        {
            return this.nome;
        }
        set
        {
            this.nome = value;
        }
    }

    public string Pclasse
    {
        get
        {
            return this.classe;
        }
        set
        {
            this.classe = value;
        }
    }

    public int Pvida
    {
        get
        {
            return this.vida;
        }
        set
        {
            this.vida = value;
        }
    }

    public int Ppoder
    {
        get
        {
            return this.poder;
        }
        set
        {
            this.poder = value;
        }
    }

    public bool GetVivo()
    {
        return vivo;
    }

    public void SetVivo(bool vivo)
    {
        this.vivo = vivo;
    }
}

public class BossTwo : BossOne
{
    protected int velocidade;

    public BossTwo(string nome, string classe, int vida, int poder, bool vivo, int velocidade) : base(nome, classe, vida, poder, vivo)
    {
        this.nome = nome;
        this.classe = classe;
        this.vida = vida;
        this.poder = poder;
        this.vivo = vivo;
        this.velocidade = velocidade;
    }

    public int GetVelocidade()
    {
        return velocidade;
    }

    public void SetVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }
}

public class BossTree : BossTwo
{
    protected bool instakill;

    public BossTree(string nome, string classe, int vida, int poder, bool vivo, int velocidade, bool instakill) : base(nome, classe, vida, poder, vivo, velocidade)
    {
        this.nome = nome;
        this.classe = classe;
        this.vida = vida;
        this.poder = poder;
        this.vivo = vivo;
        this.velocidade = velocidade;
        this.instakill = instakill;
    }

    public bool GetInstakill()
    {
        return instakill;
    }

    public void SetInstakill(bool instakill)
    {
        this.instakill = instakill;
    }
}

internal class Principal
{
    public static void Main()
    {
        Random random = new Random();
        BossOne boss1 = new BossOne("Ragnarok, the World Ender", "Guerreiro Demoníaco", 14000, 23000, true);
        BossTwo boss2 = new BossTwo("Draconis, the Ancient Wyrm", "Mestre dos Elementos", 54000, 43000, true, 7800);
        BossTree boss3 = new BossTree("Titanus, the Colossal Behemoth", "Titã da Terra", 256000, 173000, true, 32400, false);
        Player jogador = new Player("Nulo", "Nulo", 0, 0, 0, 0, 0, true, 0, 0, 0, 0);
        int[] loop = new int[10];
        string[] l = new string[20];
        int[] n = new int[20];                            // Lembra de Excluir se Precisa
        double[] d = new double[20];
        bool[] b = new bool[10];
        string[] input = new string[5];
        int[] inputint = new int[5];

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Bem Vindo ao ConsoleGame !!!");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Cadastro de Jogador");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Seu Nome: ");
        jogador.nome = Console.ReadLine().Trim();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Classes Disponiveis [Guerreiro,Atirador,Assasino]");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Sua Classe: ");
        input[0] = Console.ReadLine().ToUpper().Trim();                    // input indice 0 Sendo Ultilizado
        if (input[0] == "GUERREIRO")
        {
            jogador.classe = "Guerreiro";
            jogador.velocidade = 1100;
            jogador.energia = 500;
            jogador.energiamax = 500;
            jogador.vida = 26000;
            jogador.vidamax = 26000;
            jogador.poder = 7800;
            jogador.vivo = true;
        }
        else if (input[0] == "ATIRADOR")
        {
            jogador.classe = "Atirador";
            jogador.velocidade = 2400;
            jogador.energia = 500;
            jogador.energiamax = 500;
            jogador.vida = 14500;
            jogador.vidamax = 14500;
            jogador.poder = 10300;
            jogador.vivo = true;
        }
        else if (input[0] == "ASSASINO")
        {
            jogador.classe = "Assasino";
            jogador.velocidade = 7800;
            jogador.energia = 500;
            jogador.energiamax = 500;
            jogador.vida = 12530;
            jogador.vidamax = 12530;
            jogador.poder = 18200;
            jogador.vivo = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Opção Invalida Classe Guerreiro Colocada Como Padrão !!!");
            jogador.classe = "Guerreiro";
            jogador.velocidade = 1100;
            jogador.energia = 500;
            jogador.energiamax = 500;
            jogador.vida = 26000;
            jogador.vidamax = 26000;
            jogador.poder = 7800;
            jogador.vivo = true;
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Dinheiro Inicial Maximo [0/10000]");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Dinheiro Inicial Valor: ");
        inputint[0] = int.Parse(Console.ReadLine().Trim());              // inputint indice 0 usado aqui
        if (inputint[0] > 10000)
        {
            jogador.dinheiro = 10000;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dinheiro Maximo R10,000");
        }
        else if (inputint[0] < 0)
        {
            jogador.dinheiro = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dinheiro Minimo R$0");
        }
        else
        {
            jogador.dinheiro = inputint[0];
        }
        Thread.Sleep(2000);
        Console.Clear();

        // Final Cadastro Pessonagem

        while (loop[0] == 0)                    // Loop indice 0 Usado pra Controla Primeiro loop do Menu
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Bem Vindo Ao ConsoleGame !!!");
            Console.WriteLine("----- Menu Principal -----");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] - Aréa de Vendas / [2] - Farm / [3] - Perfil / [4] - Arena / [5] - Dessistir do Jogo");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Escolha: ");
            try
            {
                n[0] = int.Parse(Console.ReadLine().Trim());                   // n indice 0 Sendo Usado pra Pega a Escolha do Menu
                loop[0] = 1000;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro no Programa: {0}", e.Message);
                Console.WriteLine("Tente Novamente !!!");
            }
            if (n[0] > 5 || n[0] < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Opção Invalida Tente Novamente [1/5]");
                loop[0] = 0;
            }
            // Criando Loja'
            while (n[0] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("--- Bem Vindo A Loja ConsoleGame ---");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Opçoes Disponiveis: [1] - Lista de Produtos  [2] - Escolher Produto Para Compra  [3] - Menu Principal");
                Console.Write("Sua Escolha: ");
                try
                {
                    n[5] = int.Parse(Console.ReadLine().Trim());                   // n indice 5 vai ser usaod pra escolha da loja
                    n[0] = 1000;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro no Programa: {0}", e.Message);
                    Console.WriteLine("Tente Novamente !!!");
                }
                if (n[5] > 3 || n[5] < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção Invalida Tente Novamente [1/5]");
                    n[0] = 1;
                }
                if (n[5] == 1)
                {
                    produtos();
                    n[0] = 1;
                }
                if (n[5] == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Voltando Para o Menu Principal");
                    Thread.Sleep(1000);
                    loop[0] = 0;
                }
                if (n[5] == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Codigo do Produto [1/14]: ");
                    try
                    {
                        n[6] = int.Parse(Console.ReadLine());                   // n indice 6 vai ser usaod pra escolha da loja Produto
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Erro no Programa: {0}", e.Message);
                        Console.WriteLine("Tente Novamente !!!");
                    }
                    if (n[6] > 14 || n[6] < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção Invalida Tente Novamente [1/14]");
                        n[0] = 1;
                    }
                    switch (n[6])
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Espada de Espectro R$3,000");     
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 3000)
                            {
                                jogador.dinheiro = jogador.dinheiro - 3000;
                                jogador.poder = jogador.poder + 3000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 3000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Arco Flamejante R$4,200");        
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 4200)
                            {
                                jogador.dinheiro = jogador.dinheiro - 4200;
                                jogador.poder = jogador.poder + 3500;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 4200)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Martelo Trovejante R$5,700");    
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 5700)
                            {
                                jogador.dinheiro = jogador.dinheiro - 5700;
                                jogador.poder = jogador.poder + 6800;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 5700)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Lança de Gelo R$11,540");     
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 11540)
                            {
                                jogador.dinheiro = jogador.dinheiro - 11540;
                                jogador.poder = jogador.poder + 10000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 11540)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Adaga Sombria R$13,640");      
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 13640)
                            {
                                jogador.dinheiro = jogador.dinheiro - 13640;
                                jogador.poder = jogador.poder + 12000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 13640)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Foice da Morte R$18,063");     
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 18063)
                            {
                                jogador.dinheiro = jogador.dinheiro - 18063;
                                jogador.poder = jogador.poder + 17000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 18063)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 7:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Clava da Ruína R$12,230");       
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 12230)
                            {
                                jogador.dinheiro = jogador.dinheiro - 12230;
                                jogador.poder = jogador.poder + 10000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 12230)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 8:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Bastão Estelar R$17,251");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 17251)
                            {
                                jogador.dinheiro = jogador.dinheiro - 17251;
                                jogador.poder = jogador.poder + 15000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 17251)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 9:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Machado da Destruição R$23,267");    
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 23267)
                            {
                                jogador.dinheiro = jogador.dinheiro - 23267;
                                jogador.poder = jogador.poder + 21000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 23267)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 10:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Besta Mística R$8,000");     
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 8000)
                            {
                                jogador.dinheiro = jogador.dinheiro - 8000;
                                jogador.poder = jogador.poder + 6000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 8000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 11:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Cajado Mística R$27,878");      
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 27878)
                            {
                                jogador.dinheiro = jogador.dinheiro - 27878;
                                jogador.poder = jogador.poder + 23000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 27878)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 12:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Zenitê R$72,878");       
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 72878)
                            {
                                jogador.dinheiro = jogador.dinheiro - 72878;
                                jogador.poder = jogador.poder + 50000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", jogador.dinheiro, jogador.poder);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 72878)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 13:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item (10 Poção Vida) R$12,000");   
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 12000)
                            {
                                jogador.dinheiro = jogador.dinheiro - 12000;
                                jogador.ptvida += 10;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0}", jogador.dinheiro);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 12000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;

                        case 14:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item (10 Poção Energia) R$10,000");    
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            l[1] = Console.ReadLine().ToUpper();
                            if (l[1] == "S" && jogador.dinheiro >= 10000)
                            {
                                jogador.dinheiro = jogador.dinheiro - 10000;
                                jogador.ptenergia += 10;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0}", jogador.dinheiro);
                                n[0] = 1;
                            }
                            else if (l[1] == "S" && jogador.dinheiro < 10000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                n[0] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                n[0] = 1;
                            }
                            break;
                    }
                }
            }
            // Opção Perfil [3]
            if (n[0] == 3)
            {
                Thread.Sleep(100);
                getPerfil(jogador);
                loop[0] = 0;
            }

            // Opção Dessistir do Jogo [5]
            else if (n[0] == 5)
            {
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (n[0] == 5)
                {
                    Console.Write("Tem Certeza Que Deseja Dessistir? [S/N]: ");
                    input[1] = Console.ReadLine().Trim().ToUpper();
                    if (input[1] == "S")
                    {
                        Console.WriteLine("Jogo Finalizado");
                        getPerfil(jogador);
                    }
                    else
                    {
                        loop[0] = 0;
                    }
                }
            }

            // Opção Farm [2]

            while (n[0] == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                jogador.dinheiro += 23;
                Console.Write("Digite Enter Para Farma R$23 por Click Para Sair Digite [Sair]: ");
                input[1] = Console.ReadLine().Trim().ToUpper();
                if (input[1] == "SAIR")
                {
                    n[0] = 0;
                    loop[0] = 0;
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Saldo Atual R${0}", jogador.dinheiro);
                Thread.Sleep(50);
            }
            // Opção Arena De Luta
            while (n[0] == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("--- Bem Vindo a Arena de Luta !!! ---");
                Console.WriteLine("[1] - Ragnarok, the World Ender / [2] - Draconis, the Ancient Wyrm / [3] - Titanus, the Colossal Behemoth / [4] - Menu Principal / [5] - Perfil Bosses / [6] RegenVida/Energia");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Escolha: ");
                try
                {
                    n[1] = int.Parse(Console.ReadLine().Trim());                   // n indice 1 Sendo Usado pra Pega a Escolha da Arena
                    n[0] = 1000;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro no Programa: {0}", e.Message);
                    Console.WriteLine("Tente Novamente !!!");
                }
                if (n[1] > 6 || n[1] < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção Invalida Tente Novamente [1/5]");
                    n[0] = 4;
                }
                if (n[1] == 6)
                {
                    jogador.energia = jogador.energiamax;
                    jogador.vida = jogador.vidamax;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vida Regenerada");
                    Thread.Sleep(300);
                    n[0] = 4;
                }
                // Opção Volta Menu Principal
                if (n[1] == 4)
                {
                    Console.Clear();
                    Thread.Sleep(100);
                    loop[0] = 0;
                }
                // Opção Perfil Boss
                if (n[1] == 5)
                {
                    getBoss1(boss1);
                    getBoss2(boss2);
                    getBoss3(boss3);
                    n[0] = 4;
                }

                // opção batalha boss 1

                while (n[1] == 1)
                {
                    if (boss1.GetVivo() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Esse Boss ja foi Derrotado !!!");
                        n[1] = 0;
                        n[0] = 4;
                        Thread.Sleep(500);
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Status de {0}: Vida [{1}] / Energia [{2}] / [1] Ataque [{3}] / [2] Fugir / [3] PoçãoVida({4}) / [4] Poção Energia({5}): ", jogador.nome, jogador.vida, jogador.energia, jogador.poder / 5, jogador.ptvida, jogador.ptenergia);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Escolha: ");
                    try
                    {
                        // opção Fugir
                        n[2] = int.Parse(Console.ReadLine().Trim());
                        Thread.Sleep(100);
                        if (n[2] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Vocé Abandonou a Batalha !!!");
                            Console.WriteLine("Boss Regenerado !!!");
                            Thread.Sleep(2000);
                            boss1.Pvida = 14000;
                            n[1] = 0;
                            n[0] = 4;
                            Console.Clear();
                        }
                        if (n[2] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (jogador.ptvida > 0)
                            {
                                if (jogador.vida + 5700 > jogador.vidamax)
                                {
                                    jogador.vida = jogador.vidamax;
                                    jogador.ptvida -= 1;
                                }
                                else if (jogador.vida + 5700 < jogador.vidamax)
                                {
                                    jogador.vida += 5700;
                                    jogador.ptvida -= 1;
                                }
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Poçoes Insuficientes !!!");
                                Thread.Sleep(2000);
                            }
                        }
                        if (n[2] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (jogador.ptenergia > 0)
                            {
                                if (jogador.energia + 200 > jogador.energiamax)
                                {
                                    jogador.energia = jogador.energiamax;
                                    jogador.ptenergia -= 1;
                                }
                                else if (jogador.energia + 200 < jogador.energiamax)
                                {
                                    jogador.energia += 200;
                                    jogador.ptenergia -= 1;
                                }
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Poçoes Insuficientes !!!");
                                Thread.Sleep(2000);
                            }
                        }
                        // opção de ataque do Jogador
                        if (n[2] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ataque Sendo Realizado..");
                            Thread.Sleep(600);
                            if (jogador.poder / 5 > boss1.Pvida && jogador.energia > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Boss Derrotado Vida Reduzida a 0");
                                jogador.energia -= 50;
                                jogador.vidamax = 78000;
                                boss1.SetVivo(false);
                            }
                            else if (jogador.poder / 5 < boss1.Pvida && jogador.energia > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Ataque Realizado Com Dano de {0}", jogador.poder / 5);
                                jogador.energia -= 50;
                                boss1.Pvida -= jogador.poder / 5;
                                Console.WriteLine("Vida Atual do Boss {0}", boss1.Pvida);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Energia Insuficiente !!!");
                            }
                        }
                        // opção ataque do boss
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} Ésta te Atacando..", boss1.Pnome);
                        if (boss1.Ppoder / 5 > jogador.vida)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("GameOver Voce Morreu Tente Jogar Denovo outro hora !!!");
                            Console.WriteLine("Jogo Finalizado");
                            jogador.vida = 0;
                            getPerfil(jogador);
                            break;
                        }
                        else if (boss1.Ppoder / 5 < jogador.vida)
                        {
                            jogador.vida -= boss1.Ppoder / 5;
                            Console.WriteLine("Boss te Atacou com 1 Dano de {0}", boss1.Ppoder / 5);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro: {0}", e.Message);
                    }
                    if (n[2] > 4 || n[2] < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando Invalido !!!");
                        Console.WriteLine("Tente Novamente !!");
                    }
                }
                while (n[1] == 2)
                {
                    if (boss2.GetVivo() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Esse Boss ja foi Derrotado !!!");
                        n[1] = 0;
                        n[0] = 4;
                        Thread.Sleep(500);
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Status de {0}: Vida [{1}] / Energia [{2}] / [1] Ataque [{3}] / [2] Fugir / [3] PoçãoVida({4}) / [4] Poção Energia({5}): ", jogador.nome, jogador.vida, jogador.energia, jogador.poder / 5, jogador.ptvida, jogador.ptenergia);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Escolha: ");
                    try
                    {
                        // opção Fugir
                        n[2] = int.Parse(Console.ReadLine().Trim());
                        Thread.Sleep(100);
                        if (n[2] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Vocé Abandonou a Batalha !!!");
                            Console.WriteLine("Boss Regenerado !!!");
                            Thread.Sleep(2000);
                            boss2.Pvida = 24000;
                            n[1] = 0;
                            n[0] = 4;
                            Console.Clear();
                        }
                        if (n[2] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (jogador.ptvida > 0)
                            {
                                if (jogador.vida + 32400 > jogador.vidamax)
                                {
                                    jogador.vida = jogador.vidamax;
                                    jogador.ptvida -= 1;
                                }
                                else if (jogador.vida + 32400 < jogador.vidamax)
                                {
                                    jogador.vida += 32400;
                                    jogador.ptvida -= 1;
                                }
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Poçoes Insuficientes !!!");
                                Thread.Sleep(2000);
                            }
                        }
                        if (n[2] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (jogador.ptenergia > 0)
                            {
                                if (jogador.energia + 200 > jogador.energiamax)
                                {
                                    jogador.energia = jogador.energiamax;
                                    jogador.ptenergia -= 1;
                                }
                                else if (jogador.energia + 200 < jogador.energiamax)
                                {
                                    jogador.energia += 200;
                                    jogador.ptenergia -= 1;
                                }
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Poçoes Insuficientes !!!");
                                Thread.Sleep(2000);
                            }
                        }
                        // opção de ataque do Jogador
                        if (n[2] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ataque Sendo Realizado..");
                            Thread.Sleep(600);
                            if (jogador.poder / 5 > boss2.Pvida && jogador.energia > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Boss Derrotado Vida Reduzida a 0");
                                jogador.energia -= 50;
                                jogador.vidamax = 278000;
                                boss2.SetVivo(false);
                            }
                            else if (jogador.poder / 5 < boss2.Pvida && jogador.energia > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Ataque Realizado Com Dano de {0}", jogador.poder / 5);
                                jogador.energia -= 50;
                                boss2.Pvida -= jogador.poder / 5;
                                Console.WriteLine("Vida Atual do Boss {0}", boss2.Pvida);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Energia Insuficiente !!!");
                            }
                        }
                        // opção ataque do boss
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} Ésta te Atacando..", boss2.Pnome);
                        if (boss2.Ppoder / 5 > jogador.vida)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Boss te Atacou com 1 Dano de {0}", boss2.Ppoder / 5);
                            Console.WriteLine("GameOver Voce Morreu Tente Jogar Denovo outro hora !!!");
                            Console.WriteLine("Jogo Finalizado");
                            jogador.vida = 0;
                            getPerfil(jogador);
                            break;
                        }
                        else if (boss2.Ppoder / 5 < jogador.vida)
                        {
                            jogador.vida -= boss2.Ppoder / 5;
                            Console.WriteLine("Boss te Atacou com 1 Dano de {0}", boss2.Ppoder / 5);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro: {0}", e.Message);
                    }
                    if (n[2] > 4 || n[2] < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando Invalido !!!");
                        Console.WriteLine("Tente Novamente !!");
                    }
                }
                while (n[1] == 3)
                {
                    if (boss3.GetVivo() == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Esse Boss ja foi Derrotado !!!");
                        n[1] = 0;
                        n[0] = 4;
                        Thread.Sleep(500);
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Status de {0}: Vida [{1}] / Energia [{2}] / [1] Ataque [{3}] / [2] Fugir / [3] PoçãoVida({4}) / [4] Poção Energia({5}): ", jogador.nome, jogador.vida, jogador.energia, jogador.poder / 5, jogador.ptvida, jogador.ptenergia);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Escolha: ");
                    try
                    {
                        // opção Fugir
                        n[2] = int.Parse(Console.ReadLine().Trim());
                        Thread.Sleep(100);
                        if (n[2] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Vocé Abandonou a Batalha !!!");
                            Console.WriteLine("Boss Regenerado !!!");
                            Thread.Sleep(2000);
                            boss3.Pvida = 256000;
                            n[1] = 0;
                            n[0] = 4;
                            Console.Clear();
                        }
                        if (n[2] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (jogador.ptvida > 0)
                            {
                                if (jogador.vida + 86000 > jogador.vidamax)
                                {
                                    jogador.vida = jogador.vidamax;
                                    jogador.ptvida -= 1;
                                }
                                else if (jogador.vida + 86000 < jogador.vidamax)
                                {
                                    jogador.vida += 86000;
                                    jogador.ptvida -= 1;
                                }
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Poçoes Insuficientes !!!");
                                Thread.Sleep(2000);
                            }
                        }
                        if (n[2] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (jogador.ptenergia > 0)
                            {
                                if (jogador.energia + 200 > jogador.energiamax)
                                {
                                    jogador.energia = jogador.energiamax;
                                    jogador.ptenergia -= 1;
                                }
                                else if (jogador.energia + 200 < jogador.energiamax)
                                {
                                    jogador.energia += 200;
                                    jogador.ptenergia -= 1;
                                }
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Poçoes Insuficientes !!!");
                                Thread.Sleep(2000);
                            }
                        }
                        // opção de ataque do Jogador
                        if (n[2] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Ataque Sendo Realizado..");
                            Thread.Sleep(600);
                            if (jogador.poder / 5 > boss3.Pvida && jogador.energia > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Boss Derrotado Vida Reduzida a 0");
                                jogador.energia -= 50;
                                boss3.SetVivo(false);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("PARABENS VOCE ZEROU O JOGO");
                                Console.WriteLine("ATE A PROXIMA VEZ");
                                getPerfil(jogador);
                            }
                            else if (jogador.poder / 5 < boss3.Pvida && jogador.energia > 50)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Ataque Realizado Com Dano de {0}", jogador.poder / 5);
                                jogador.energia -= 50;
                                boss3.Pvida -= jogador.poder / 5;
                                Console.WriteLine("Vida Atual do Boss {0}", boss3.Pvida);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Energia Insuficiente !!!");
                            }
                        }
                        // opção ataque do boss
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} Ésta te Atacando..", boss3.Pnome);
                        if (boss3.Ppoder / 5 > jogador.vida)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Boss te Atacou com 1 Dano de {0}", boss3.Ppoder / 5);
                            Console.WriteLine("GameOver Voce Morreu Tente Jogar Denovo outro hora !!!");
                            Console.WriteLine("Jogo Finalizado");
                            jogador.vida = 0;
                            getPerfil(jogador);
                            break;
                        }
                        else if (boss3.Ppoder / 5 < jogador.vida)
                        {
                            jogador.vida -= boss3.Ppoder / 5;
                            Console.WriteLine("Boss te Atacou com 1 Dano de {0}", boss3.Ppoder / 5);
                        }
                        n[4] = random.Next(0, 101); /////////////
                        if (n[4] == 13)
                        {
                            boss3.SetInstakill(true);
                            Console.WriteLine("Modo Instakill Ativado !!!");
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Boss te Atacou com 1 Dano de {0}", boss3.Ppoder + 500000);
                            Console.WriteLine("GameOver Voce Morreu Tente Jogar Denovo outro hora !!!");
                            Console.WriteLine("Jogo Finalizado");
                            jogador.vida = 0;
                            getPerfil(jogador);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro: {0}", e.Message);
                    }
                    if (n[2] > 4 || n[2] < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando Invalido !!!");
                        Console.WriteLine("Tente Novamente !!");
                    }
                }
            }
        }
    }

    public static void getPerfil(Player jogador)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--- Perfil de {0} ---", jogador.nome);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", jogador.vida);
        Console.WriteLine("Classe: {0}", jogador.classe);
        Console.WriteLine("Poder Total: {0}", jogador.poder);
        Console.WriteLine("Energia Atual [MAX 500]: {0}", jogador.energia);
        Console.WriteLine("Velocidade: {0}", jogador.velocidade);
        Console.WriteLine("Dinheiro Atual: {0}", jogador.dinheiro);
        Console.WriteLine("Poçoes de Vida: {0}", jogador.ptvida);
        Console.WriteLine("Poçoes de Energia: {0}", jogador.ptenergia);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Digite Enter Para Sair");
        Console.ReadLine();
        Console.Clear();
    }

    public static void getBoss1(BossOne boss1)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--- Perfil de {0} ---", boss1.Pnome);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", boss1.Pvida);
        Console.WriteLine("Classe: {0}", boss1.Pclasse);
        Console.WriteLine("Poder Total: {0}", boss1.Ppoder);
        Console.WriteLine("Esta Vivo?: {0}", boss1.GetVivo());
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--------------------");
    }

    public static void getBoss2(BossTwo boss2)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--- Perfil de {0} ---", boss2.Pnome);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", boss2.Pvida);
        Console.WriteLine("Classe: {0}", boss2.Pclasse);
        Console.WriteLine("Poder Total: {0}", boss2.Ppoder);
        Console.WriteLine("Velocidade: {0}", boss2.GetVelocidade());
        Console.WriteLine("Esta Vivo?: {0}", boss2.GetVivo());
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--------------------");
    }

    public static void getBoss3(BossTree boss3)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--- Perfil de {0} ---", boss3.Pnome);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", boss3.Pvida);
        Console.WriteLine("Classe: {0}", boss3.Pclasse);
        Console.WriteLine("Poder Total: {0}", boss3.Ppoder);
        Console.WriteLine("Velocidade: {0}", boss3.GetVelocidade());
        Console.WriteLine("Esta Vivo?: {0}", boss3.GetVivo());
        Console.WriteLine("InstaKill: {0}", boss3.GetInstakill());
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Digite Enter Para Sair");
        Console.ReadLine();
        Console.Clear();
    }

    public static void produtos()                            // Metodo pra Chama lista Loja
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[01] Espada de Espectro...:  -  R$3,000  - Poder + 2,200");
        Console.WriteLine("[02] Arco Flamejante......:  -  R$4,200  - Poder + 3,500");
        Console.WriteLine("[03] Martelo Trovejante...:  -  R$5,700  - Poder + 6,800");     // Compra ate aqui ajuda no primeiro boss
        Console.WriteLine("[04] Lança de Gelo........:  -  R$11,540  - Poder + 10,000");
        Console.WriteLine("[05] Adaga Sombria........:  -  R$13,640  - Poder + 12,000");
        Console.WriteLine("[06] Foice da Morte.......:  -  R$18,063  - Poder + 17,000");        // ate aqui segundo boss completa 60k
        Console.WriteLine("[07] Clava da Ruína.......:  -  R$12,230  - Poder + 10,000");
        Console.WriteLine("[08] Bastão Estelar.......:  -  R$17,251  - Poder + 15,000");
        Console.WriteLine("[09] Machado da Destruição:  -  R$23,267  - Poder + 21,000");
        Console.WriteLine("[10] Besta Mística........:  -  R$8,000  - Poder + 6,000");
        Console.WriteLine("[11] Cajado Mística.......:  -  R$27,878  - Poder + 23,000");
        Console.WriteLine("[12] Zenitê...............:  -  R$72,878  - Poder + 50.000");
        Console.WriteLine("[13] 10 Poção Vida........:  -  R$12,000");
        Console.WriteLine("[14] 10 Poção Energia.....:  -  R$10,000");
    }
}