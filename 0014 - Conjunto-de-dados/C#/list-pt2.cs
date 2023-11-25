using System;
using System.Collections.Generic;

class Project {
    static void Main(){
        List<string> carros = new List<string>();

        carros.Add("Ferrari");
        carros.Add("Prima");
        carros.Add("Corola");
        carros.Add("Mercedes");
        carros.Add("Corola");
        carros.Add("jaguar");
        carros.Add("Ferrari");

        carros.Insert(1, "Fusca");

        carros.Remove("Prima");
        carros.RemoveAt(0);

        carros.Reverse();
        carros.Sort();

        Console.WriteLine("Quantidade de carros: {0}", carros.Count);
        Console.WriteLine("Capacidade da lista de carros: {0}", carros.Capacity);

        Console.WriteLine(carros.LastIndexOf("Corola"));
        foreach(string item in carros) {
            Console.WriteLine(item);
        }
    }
}