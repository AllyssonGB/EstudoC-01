using System;

internal class Compra
{                                                           // D e V Indices 1 E Estoque e Dinheiro
    public static void Main()
    {
        float[] v = { 0, 0, 0, 0, 0, 0 };
        int[] d = { 0, 0, 0 };

        while (v[0] == 0)            // Variavel 0 vai ser o ponto de partida dos While e IF
        {
            Console.Write("Digite A Quantidade em Dinheiro que Deseja Iniciar: ");
            v[1] = float.Parse(Console.ReadLine());                                                                     // Dinheiro Geral vai ser V indice 1
            v[0] = 1;
        }
        while (v[2] == 0)            // Variavel 2 vai ser o ponto de partida dos While e IF
        {
            Console.WriteLine("Bem Vindo a o Sistema de Compras !!!");
            Console.WriteLine("1 - Loja do Jhonatha  2 - Loja do Andre  3 - Loja do Everaldo  4 - Saldo/Estoque  5 - Aréa de Vendas  6 - Adiciona Dinheiro  7 - Finaliza Programa");
            v[0] = float.Parse(Console.ReadLine());
            v[2] = 100;
            if (v[0] == 1)
            {
                Console.WriteLine("Bem Vindo a Loja do Jhonatha Vendo Produtos a R$3.75");
                Console.Write("Quantos Produtos Deseja Compra: ");
                d[0] = int.Parse(Console.ReadLine());                                                 // D com Indice 0 Vai ser Usado Para Compra
                if (d[0] * 3.75f <= v[1])
                {
                    v[4] = d[0];                      // V Indice 4 Usado Pra Armazena os Valores de cada Loja
                    v[3] = 3.75f * v[4];
                    v[1] = v[1] - v[3];
                    d[1] = d[1] + d[0];        // Indice D 1 Vai ser o Estoque
                    Console.WriteLine("Sua Compra No Valor de R${0} é {1} Itens é o Seu Estoque Atual é de {2} é o Saldo de R${3}", v[3], d[0], v[4], v[1]);
                    v[2] = 0;
                    continue;
                }   
                else if (d[0] * 3.75f > v[1])
                {
                    Console.WriteLine("Vocé não tem Dinheiro Suficiente Venda Algo ou Procure Algo Mais Barato !!!");
                    v[2] = 0;
                    continue;
                }
                else
                {
                    Console.WriteLine("Erro no Programa Por Favor Reinicie");
                }
            }
            if (v[0] == 2)
            {
                Console.WriteLine("Bem Vindo a Loja do Andre Vendo Produtos a R$7.00");
                Console.Write("Quantos Produtos Deseja Compra: ");
                d[0] = int.Parse(Console.ReadLine());
                if (d[0] * 7.00f <= v[1])
                {
                    v[4] = d[0];
                    v[3] = 7.00f * v[4];
                    v[1] = v[1] - v[3];
                    d[1] = d[1] + d[0];
                    Console.WriteLine("Sua Compra No Valor de R${0} é {1} Itens é o Seu Estoque Atual é de {2} é o Saldo de R${3}", v[3], d[0], d[1], v[1]);
                    v[2] = 0;
                    continue;
                }
                else if (d[0] * 7.00f > v[1])
                {
                    Console.WriteLine("Vocé não tem Dinheiro Suficiente Venda Algo ou Procure Algo Mais Barato !!!");
                    v[2] = 0;
                    continue;
                }
                else
                {
                    Console.WriteLine("Erro no Programa Por Favor Reinicie");
                }
            }
            if (v[0] == 3)
            {
                Console.WriteLine("Bem Vindo a Loja do Everaldo Vendo Produtos a R$4.57");
                Console.Write("Quantos Produtos Deseja Compra: ");
                d[0] = int.Parse(Console.ReadLine());
                if (d[0] * 4.57f <= v[1])
                {
                    v[4] = d[0];
                    v[3] = 4.57f * v[4];
                    v[1] = v[1] - v[3];
                    d[1] = d[1] + d[0];
                    Console.WriteLine("Sua Compra No Valor de R${0} é {1} Itens é o seu Estoque Atual é de {2} é o Saldo de R${3}", v[3], d[0], d[1], v[1]);
                    v[2] = 0;
                    continue;                
                }
                else if (d[0] * 4.57f > v[1]){
                    Console.WriteLine("Vocé não tem Dinheiro Suficiente Venda Algo ou Procure Algo Mais Barato !!!");
                    v[2] = 0;
                    continue;
                }
            }
            if (v[0] == 4)
            {
                Console.WriteLine("Seu Saldo é De R${0}", v[1]);
                Console.WriteLine("Seu Estoque é De {0}", d[1]);
                v[2] = 0;
                continue;
            }
            if (v[0] == 7)
            {
                Console.WriteLine("Programa Finzalido !!!");
                Console.WriteLine("Estoque: {0}", d[1]);
                Console.WriteLine("Dinheiro: {0}", v[1]);
                break;
            }
            if (v[0] == 6)
            {
                Console.Write("Digite A Quantidade em Dinheiro que Deseja Iniciar: ");
                v[5] = float.Parse(Console.ReadLine());
                v[1] += v[5];
                v[2] = 0;
                continue;
            }
            while (v[0] == 5)
            {
                Console.WriteLine("Bem Vindo a Aréa De Vendas");
                Console.WriteLine("1 - Cliente Gilvan  2 - Cliente Lucas  3 - Revendedores  4 - Volta Menu De Compra  5 - Finaliza Programa");
                v[4] = float.Parse(Console.ReadLine());
                v[0] = 100;
                if (v[4] == 1)
                {
                    Console.WriteLine("Gilvan esta Comprando Itens por R$6.70");
                    Console.Write("Deseja Vende Quantos Itens: ");
                    d[0] = int.Parse(Console.ReadLine());
                    if (d[0] <= d[1])
                    {
                        d[1] = d[1] - d[0];
                        v[1] = v[1] + (d[0] * 6.70f);
                        v[3] = d[0] * 6.70f;
                        Console.WriteLine("Venda de {0} Itens no Valor de {1} Foi Realizada\nEstoque: {2}\nSaldo: R${3}", d[0], v[3], d[1], v[1]);
                        v[0] = 5;
                        continue;
                    }
                    else if (d[0] > d[1])
                    {
                        Console.WriteLine("Ñão Foi possivel fazer a venda pois vocé não tem estoque !!! Estoque: {0}", d[1]);
                        v[0] = 5;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Erro no Programa Por Favor Reinicie");
                    }
                }
                if (v[4] == 2)
                {
                    Console.WriteLine("Lucas esta Comprando Itens por R$8.89");
                    Console.WriteLine("Deseja Vende Quantos Itens: ");
                    d[0] = int.Parse(Console.ReadLine());
                    if (d[0] <= d[1])
                    {
                        d[1] = d[1] - d[0];
                        v[1] = v[1] + (d[0] * 8.89f);
                        v[3] = d[0] * 8.89f;
                        Console.WriteLine("Vende de {0} Itens no Valor de {1} Foi Realizada\nEstoque: {2}\nSaldo: R${3}", d[0], v[3], d[1], v[1]);
                        v[0] = 5;
                        continue;
                    }
                    else if (d[0] > d[1])
                    {
                        Console.WriteLine("Ñão Foi possivel fazer a venda pois vocé não tem estoque !!! Estoque: {0}", d[1]);
                        v[0] = 5;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Erro no Programa Por Favor Reinicie");
                    }
                    
                }
                if (v[4] == 3)
                {
                    Console.WriteLine("Revendedor esta Comprando Itens por R$5.14");
                    Console.WriteLine("Deseja Vende Quantos Itens: ");
                    d[0] = int.Parse(Console.ReadLine());
                    if (d[0] <= d[1])
                    {
                        d[1] = d[1] - d[0];
                        v[1] = v[1] + (d[0] * 5.14f);
                        v[3] = d[0] * 5.14f;
                        Console.WriteLine("Vende de {0} Itens no Valor de {1} Foi Realizada\nEstoque: {2}\nSaldo: R${3}", d[0], v[3], d[1], v[1]);
                        v[0] = 5;
                        continue;
                    }
                    else if (d[0] > d[1])
                    {
                        Console.WriteLine("Ñão Foi possivel fazer a venda pois vocé não tem estoque !!! Estoque: {0}", d[1]);
                        v[0] = 5;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Erro no Programa Por Favor Reinicie");
                    }

                }
                if (v[4] == 666)
                {
                    Console.WriteLine("Vocé Esta Amaldicoado , Até Um Outro Dia...");
                    v[0] = 0;
                }
                if (v[4] == 5)
                {
                    Console.WriteLine("Programa Finzalido !!!");
                    Console.WriteLine("Estoque: {0}", d[1]);
                    Console.WriteLine("Dinheiro: {0}", v[1]);
                    break;
                }
                if (v[4] == 4)
                {
                    v[2] = 0;
                }
            }
        }

    }
}