using System;
using System.Collections.Generic;

class Project {
    static void Main(){
        // AddFirst    = Adiciona no inicio da lista
        // AddLast     = Adiciona no fim da lista
        // AddAfter    = Adiciona depois de um elemento
        // AddBefore   = Adiciona antes de um elemento
        // FindLast    = Encontrar ultimo
        // Clear       = Remove todos
        // Remove      = Remove um a partir do nome
        // RemoveFirst = Remove primeiro elemento
        // RemoveLast  = Remove último elemento
        // .Next       = Aponta para o próximo
        // .Previous   = Aponta para o anterior
        // .Value      = Mostra o próprio valor

        LinkedList<string> transp = new LinkedList<string>();
        
        transp.AddLast("Jato");
        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Motocicleta");

        LinkedListNode<string> no1 = transp.FindLast("Avião");
        LinkedListNode<string> no1b = transp.FindLast("Avião").Next;
        transp.AddAfter(no1, "Monociclo");

        LinkedListNode<string> no2 = transp.FindLast("Carro");
        LinkedListNode<string> no2b = transp.FindLast("Carro").Previous;
        transp.AddBefore(no2, "Patinete");

        string no3 = transp.FindLast("Carro").Value; // Busca ele mesmo

        // transp.Clear();
        string verify = "patinete";
        if(transp.Find(verify) != null) {
            Console.WriteLine("=> {0} está na lista", verify);
        } else {
            Console.WriteLine("=> {0} não está na lista", verify);
        }

        transp.Remove("Monociclo");

        foreach (string item in transp){
            Console.WriteLine(item);
        }

        transp.RemoveFirst();
        transp.RemoveLast();

        Console.WriteLine("================================================");
        foreach (string item in transp){
            Console.WriteLine(item);
        }
    }
}