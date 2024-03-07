using System;

public class Player                      // Construtor do Jogador do Player Principal
{
    public string nome, classe;
    public int poder, energia, velocidade, vida;
    public float dinheiro;
    public bool vivo;

    public Player(string nome, string classe, int poder,int vida, int energia, int velocidade, float dinheiro, bool vivo)      // Construtor do Jogador do Player Principal
    {
        this.nome = nome;
        this.classe = classe;
        this.poder = poder;
        this.vida = vida;
        this.energia = energia;
        this.velocidade = velocidade;
        this.dinheiro = dinheiro;
        this.vivo = vivo;
    }
}

public class Bosses                 // Construtor Para o Primeiro Boss
{
    private string nome, classe;
    private int poder, vida;
    private bool vivo;

    public Bosses(string nome, string classe, int poder,int vida, bool vivo)                     // Atributos que o Primeiro Boss Vai Ter
    {
        this.nome = nome;
        this.classe = classe;
        this.poder = poder;
        this.vida = vida;
        this.vivo = vivo;
    }

    public string getNome()
    {
        return nome;
    }
    public string getClasse()
    {
        return classe;
    }
    public int getPoder()
    {
        return poder;
    }
    public int getVida()
    {
        return vida;
    }
    public bool getvivo()
    {
        return vivo;
    }
}

public class BossTwo : Bosses
{
    private int velocidade;
    public BossTwo(string nome, string classe, int poder, int vida, bool vivo, int velocidade) : base(nome, classe, poder, vida, vivo)        // Atributos a Mais que o Segundo Boss Vai Receber
    {
        this.velocidade = velocidade;
    }

    public int getVelocidade()
    {
        return velocidade;
    }
}

public class BossTree : BossTwo
{
    private bool instakill;
    public BossTree(string nome,string classe,int poder, int vida, bool vivo, int velocidade, bool instakill): base(nome,classe, poder, velocidade, vivo, vida) // Atributos a Mais que o Terceiro Boss Vai Receber
    {
        this.instakill = instakill;
    }
    public bool getInstakill()
    {
        return instakill;
    }
}


internal class Principal
{
    public static void Main()
    {
        Bosses Boss1 = new Bosses("Titan Of Destruction", "TITAN", 27000, 800000, true);       // Poder é Vida nessa ordem , os que tem a mias é a Velocidade
        BossTwo Boss2 = new BossTwo("God Of Destruction", "GOD", 187000, 6540000, true, 40000);
        BossTree Boss3 = new BossTree("Abomination & Mutant", "GOD", 56800000, 740000, true, 230000, false);
        Player player = new Player("Nulo","Nulo",0,0,0,0,0,true);

        // Criação Pessonagem Principal
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-- Cadastro do Pessonagem Principal --");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Digite o Nome do Seu Pessonagem Principal: ");
        player.nome = Console.ReadLine();
        Console.Write("Digite a Classe do Seu Pessonagem [Arqueiro/Guerreiro/Mago]: ");
        player.classe = Console.ReadLine().ToUpper();
        if(player.classe == "ARQUEIRO")
        {
            player.poder = 13000;
            player.vida = 20000;
            player.energia = 100;
            player.velocidade = 7000;
        }
        else if (player.classe == "GUERREIRO")
        {
            player.poder = 8700;
            player.vida = 56000;
            player.energia = 200;
            player.velocidade = 0;
        }
        else if (player.classe == "MAGO")
        {
            player.poder = 23000;
            player.vida = 7000;
            player.energia = 500;
            player.velocidade = 4500;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro na Criação de Pessonagem Por Favor reinicie o Programa");
            Console.ReadLine();
        }
        Console.Write("Quantidade de Dinheiro Que quer Iniciar Isso Vai Definir a Dificuldade Inicial [0/5000]: ");
        float dificuldade = float.Parse(Console.ReadLine());
        if (dificuldade >= 0 && dificuldade <= 5000)
        {
            player.dinheiro = dificuldade;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro na Criação de Pessonagem Por Favor reinicie o Programa");
            Console.ReadLine();
        }
        player.vivo = true;
        player = new Player(player.nome, player.classe, player.poder, player.vida, player.energia, player.velocidade, player.dinheiro,player.vivo);

        int[] inteiro = new int[20];       // Criação das Variaveis Pra Inicia o Jogo          // Inteiro Com Indices 0,1,2 Reservados pra Laços de LOOP
        float[] flutuante = new float[20];
        string[] print = new string[20];
        inteiro[0] = 0;
        while (inteiro[0] == 0)           // inteiro indice 0 usado pra essa escolha
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--- Bem Vindo Ao Jogo GamersOfWar ---");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Opçoes Disponiveis: [1] - Loja  [2] - FarmDinheiro  [3] - Arena De Lutas  [4] - Perfil  [5] - Desistir do Jogo");
            Console.Write("Sua Escolha: ");
            inteiro[3] = int.Parse(Console.ReadLine());                // inteiro indice 3 usado pra essa escolha
            inteiro[0] = 1000;
            if (inteiro[3] <= 0 || inteiro[3] > 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro no Programa Escolhe Uma Opção Existente");
                inteiro[0] = 0;
            }
            while (inteiro[3] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("--- Bem Vindo A Loja GamersOfWar Studenty ---");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Opçoes Disponiveis: [1] - Lista de Produtos  [2] - Escolher Produto Para Compra  [3] - Menu Principal");
                Console.Write("Sua Escolha: ");
                inteiro[4] = int.Parse(Console.ReadLine());
                inteiro[3] = 1000;
                if (inteiro[4] > 3 || inteiro[4] <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro no Programa Escolhe Uma Opção Existente");
                    inteiro[3] = 1;
                }
                else if (inteiro[4] == 1)
                {
                    produtos();
                    inteiro[3] = 1;
                }
                else if (inteiro[4] == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Codigo do Produto [1/12]: ");
                    inteiro[5] = int.Parse(Console.ReadLine());
                    switch (inteiro[5])
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Espada de Espectro R$17,000");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 17000)
                            {
                                player.dinheiro = player.dinheiro - 17000;
                                player.poder = player.poder + 22000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 17000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Arco Flamejante R$62,580");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 62580)
                            {
                                player.dinheiro = player.dinheiro - 62580;
                                player.poder = player.poder + 54000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 62580)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Martelo Trovejante R$34,030");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 34030)
                            {
                                player.dinheiro = player.dinheiro - 34030;
                                player.poder = player.poder + 45000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 34030)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Lança de Gelo R$87,000");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 87000)
                            {
                                player.dinheiro = player.dinheiro - 87000;
                                player.poder = player.poder + 77000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 87000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Adaga Sombria R$112,000");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 112000)
                            {
                                player.dinheiro = player.dinheiro - 112000;
                                player.poder = player.poder + 202000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 112000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Foice da Morte R$98,063");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 98063)
                            {
                                player.dinheiro = player.dinheiro - 98063;
                                player.poder = player.poder + 87000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 98063)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Clava da Ruína R$507,230");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 507230)
                            {
                                player.dinheiro = player.dinheiro - 507230;
                                player.poder = player.poder + 780000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 507230)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Bastão Estelar R$134,251");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 134251)
                            {
                                player.dinheiro = player.dinheiro - 134251;
                                player.poder = player.poder + 367000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 134251)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Machado da Destruição R$1,267,870");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 1267870)
                            {
                                player.dinheiro = player.dinheiro - 1267870;
                                player.poder = player.poder + 3567000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 1267870)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 10:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Besta Mística R$878,000");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 878000)
                            {
                                player.dinheiro = player.dinheiro - 878000;
                                player.poder = player.poder + 1560000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 878000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Cajado Mística R$12,878,000");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 12878000)
                            {
                                player.dinheiro = player.dinheiro - 12878000;
                                player.poder = player.poder + 32563040;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 12878000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vocé Escolheu o Item Zenitê R$7,878,000");
                            Console.Write("Deseja Fazer a Compra [S/N]: ");
                            print[0] = Console.ReadLine().ToUpper();
                            if (print[0] == "S" && player.dinheiro >= 7878000)
                            {
                                player.dinheiro = player.dinheiro - 7878000;
                                player.poder = player.poder + 21560000;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Compra Finalizada Saldo: {0} Poder: {1}", player.dinheiro, player.poder);
                                inteiro[3] = 1;
                            }
                            else if (print[0] == "S" && player.dinheiro < 7878000)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Saldo Insificiente Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Opção Invalida Voltando Para Loja");
                                inteiro[3] = 1;
                            }
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Opção Invalida Voltando Para Loja");
                            inteiro[3] = 1;
                            break;
                    }

                }
                else if (inteiro[4] == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Voltando Para o Menu Principal");
                    inteiro[0] = 0;
                }

            }
            while (inteiro[3] == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Clique Enter Para Farma 7000 Saldo Por Click, Para Sair Digite [Sair]: ");
                print[0] = Console.ReadLine().ToUpper();
                if (print[0] == "SAIR")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Voltando Para o Menu Principal Valor Farmado {0}", inteiro[4]);
                    player.dinheiro += inteiro[4];
                    inteiro[3] = 100;
                    inteiro[0] = 0;
                }
                else if(print[0] != "SAIR")
                {
                    inteiro[4] += 7000;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Foi Adicionado 7000 Valor Total Farmado na Sesão {0}",inteiro[4]);
                }
            }
            if (inteiro[3] == 4)
            {
                info(player);
                inteiro[0] = 0;
            }
            if (inteiro[3] == 5)
            {
                info(player);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Jogo Finalizado , Boa Sorte Na Proxima Vez");
                Console.ReadLine();
                break;
            }
            while (inteiro[3] == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---- Bem Vindo a Arena de Jogos !!! ----");
                Console.WriteLine("Opçoes Disponiveis: [1] - Titan Of Destruction  [2] - God Of Destruction  [3] - Abomination & Mutant  [4] - Status Dos Bosses  [5] - Menu Principal");
                Console.Write("Sua Escolha: ");
                inteiro[5] = int.Parse(Console.ReadLine());
                inteiro[3] = 1000;
                if (inteiro[5] <= 0 || inteiro[5] > 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Erro no Programa Escolhe Uma Opção Existente");
                    inteiro[3] = 3;
                }
                if (inteiro[5] == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Voltando Para o Menu Principal");
                    inteiro[0] = 0;
                }
                if (inteiro[5] == 4)
                {
                    boss(Boss1);
                    boss2(Boss2);
                    boss3(Boss3);
                    inteiro[3] = 3;
                }
            }
        }
    }
    

    public static void info(Player player)          // Metodo pra Chama Perfil
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--- Perfil de {0} ---", player.nome);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", player.vida);
        Console.WriteLine("Classe: {0}", player.classe);
        Console.WriteLine("Poder Total: {0}", player.poder);
        Console.WriteLine("Energia Atual [MAX 500]: {0}", player.energia);
        Console.WriteLine("Velocidade: {0}", player.velocidade);
        Console.WriteLine("Dinheiro Atual: {0}", player.dinheiro);
    }

    public static void produtos()                            // Metodo pra Chama lista Loja
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("[01] Espada de Espectro...:  -  R$17,000  - Poder + 22,000");
        Console.WriteLine("[02] Arco Flamejante......:  -  R$62,580  - Poder + 54,000");
        Console.WriteLine("[03] Martelo Trovejante...:  -  R$34,030  - Poder + 45,000");
        Console.WriteLine("[04] Lança de Gelo........:  -  R$87,000  - Poder + 77,000");
        Console.WriteLine("[05] Adaga Sombria........:  -  R$112,000  - Poder + 202,000");
        Console.WriteLine("[06] Foice da Morte.......:  -  R$98,063  - Poder + 87,000");
        Console.WriteLine("[07] Clava da Ruína.......:  -  R$507,230  - Poder + 780,000");
        Console.WriteLine("[08] Bastão Estelar.......:  -  R$134,251  - Poder + 367,000");
        Console.WriteLine("[09] Machado da Destruição:  -  R$1,267,870  - Poder + 3,567,000");
        Console.WriteLine("[10] Besta Mística........:  -  R$878,000  - Poder + 1,560,000");
        Console.WriteLine("[11] Cajado Mística.......:  -  R$12,878,000  - Poder + 32,563,040");
        Console.WriteLine("[12] Zenitê...............:  -  R$7,878,000  - Poder + 21,560,000");
    }
    public static void boss(Bosses Boss1)          
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------");
        Console.WriteLine("{0}", Boss1.getNome());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", Boss1.getVida());
        Console.WriteLine("Classe: {0}", Boss1.getClasse());
        Console.WriteLine("Poder Total: {0}", Boss1.getPoder());
        Console.WriteLine("Vivo: {0}", Boss1.getvivo());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------");
    }
    public static void boss2(BossTwo Boss2)          
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------");
        Console.WriteLine("{0}", Boss2.getNome());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", Boss2.getVida());
        Console.WriteLine("Classe: {0}", Boss2.getClasse());
        Console.WriteLine("Poder Total: {0}", Boss2.getPoder());
        Console.WriteLine("Vivo: {0}", Boss2.getvivo());
        Console.WriteLine("Velocidade: {0}", Boss2.getVelocidade());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------");
    }
    public static void boss3(BossTree Boss3)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------");
        Console.WriteLine("{0}", Boss3.getNome());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Vida Total: {0}", Boss3.getVida());
        Console.WriteLine("Classe: {0}", Boss3.getClasse());
        Console.WriteLine("Poder Total: {0}", Boss3.getPoder());
        Console.WriteLine("Vivo: {0}", Boss3.getvivo());
        Console.WriteLine("Velocidade: {0}", Boss3.getVelocidade());
        Console.WriteLine("InstaKill: {0}", Boss3.getInstakill());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------");
    }



}