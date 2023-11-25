using System;
using System.Collections.Generic;

class Project {
    static void Main(){
        string[] listCurrent = {"Ferrari", "Ford K", "Uno", "Corola"};
        Queue<string> veiculos = new Queue<string>(listCurrent);

        veiculos.Enqueue("Fusca");

        string v = "Fusca";
        if(veiculos.Contains(v)) {
            Console.WriteLine("{0} está na fila", v);
        }

        // veiculos.Clear();

        Console.WriteLine("Quantidade de elementos na fila: {0}", veiculos.Count);

        Console.WriteLine("{0} vai passar", veiculos.Peek());

        Console.WriteLine("{0} passou", veiculos.Dequeue());

        Console.WriteLine("Quantidade de elementos na fila: {0}", veiculos.Count);
        Console.WriteLine("=======================================================");
        foreach(string veic in veiculos) {
            Console.WriteLine(veic);
        }
        Console.WriteLine("=======================================================");
        while(veiculos.Count > 0) {
            Console.WriteLine("{0} passou", veiculos.Dequeue());
        }
        Console.WriteLine("Quantidade de elementos na fila: {0}", veiculos.Count);
    }
}