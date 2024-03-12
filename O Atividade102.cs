using System;
using System.Collections.Generic;

// Coleção LinkedList / Lista duplamente encadeada // https://www.youtube.com/watch?v=RCWPih5bEVs
// onde cada elemento é um nó da lista e o elemento é ligado ao elemento anterior e posterior

    class Aula56
    {
        static void Main(string[] args)
        {
            LinkedList<string> transp = new LinkedList<string>();

            transp.AddFirst("carro");
            transp.AddFirst("aviao");
            transp.AddFirst("navio");
            transp.AddFirst("motocicleta");
            transp.AddFirst("navio");

            transp.AddLast("bicicleta");
            transp.AddLast("navio");

            LinkedListNode<string> no;


            no = transp.FindLast("navio");//procura o ULTIMO valor navio e insere no nó
            transp.AddAfter(no, "patinete"); //adiciona DEPOIS do ultimo navio o patinete

            no = transp.Find("navio");//procura o PRIMEIRO valor navio e insere no nó "The LinkedList<T> is searched forward starting at First and ending at Last."
            transp.AddBefore(no, "patins");// adiciona patins ANTES do ultimo navio

            no = transp.FindLast("navio");
            transp.AddBefore(no, "bike");//adiciona bike ANTES do ultimo navio
            transp.AddAfter(no, "helicoptero");//adiciona helicoptero DEPOIS do ultimo navio

            //transp.Remove("navio"); //remove o elemento,caso tenha varios com o mesmo nome removerá o primeiro
            //transp.RemoveFirst();// remove o primeiro elemento
            //transp.RemoveLast();// remove o ultimo elemento
            //transp.Clear(); //limpa a lista inteira

            if (transp.Find("Carro") == null) // FIND é para encontrar elementos
            {

                Console.WriteLine("Não encontrado");
            }
            else
            {
                Console.WriteLine("Elemento encontrado");
            }

            no = transp.FindLast("navio").Next; //acha o elemento seguinte ao nó encontrado
            Console.WriteLine("depois do ultimo navio:{0}", no.Value);
            no = transp.FindLast("navio").Previous; //acha o elemento anterior ao nó encontrado
            Console.WriteLine("antes do ultimo navio:{0}", no.Value);

            foreach (var t in transp)
            {
                Console.WriteLine(t);
            }


        }
    }