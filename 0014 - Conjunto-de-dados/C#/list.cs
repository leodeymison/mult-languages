using System;
using System.Collections.Generic;

class Project {
    static void Main(){
        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>();

        carros.Add("Ferrari");
        carros.Add("Corola");
        carros.Add("Mercedes");

        carros2.AddRange(carros);

        // carros2.Clear();

        if(carros.Contains("Mercedes")) {
            Console.WriteLine("Carro existe na list");
        }

        foreach(string item in carros2) {
            Console.WriteLine(item);
        }

        string[] carros3 = new string[4];
        carros.CopyTo(carros3, 1);
        Console.WriteLine("====================================");
        foreach(string item in carros3) {
            Console.WriteLine(item);
        }

        Console.WriteLine("Posição do valor Ferrari: {0}", carros2.IndexOf("Ferrari"));
    }
}