using Internal;
using System;
using System.Collections.Generic;

class Project {
    static void Main(){
        Dictionary <int, string> veiculo = new Dictionary<int, string>();

        veiculo.Add(10, "Carro");
        veiculo.Add(5, "Avião");
        veiculo.Add(0, "Navio");
        veiculo.Add(1, "Motocicleta");

        // veiculo.Clear();
        Console.WriteLine("Tamanho do dicionário: {0}", veiculo.Count);

        int elemIndex = 23;
        if(veiculo.ContainsKey(elemIndex)) {
            Console.WriteLine("Chave: [{0}] - Existe elemento com essa chave", elemIndex);
        } else {
            Console.WriteLine("Chave: [{0}] - Não existe elemento com essa chave", elemIndex);
        }
        string elemName = "Navio";
        if(veiculo.ContainsValue(elemName)) {
            Console.WriteLine("{0} existe", elemName);
        } else {
            Console.WriteLine("{0} não existe", elemName);
        }

        veiculo.Remove(10);
        Console.WriteLine("Tamanho do dicionário: {0}", veiculo.Count);

        string elemName2 = "Patinete";
        veiculo[10] = elemName2; // Add patinete and remove carro
        if(veiculo.ContainsValue(elemName2)) {
            Console.WriteLine("{0} existe", elemName2);
        } else {
            Console.WriteLine("{0} não existe", elemName2);
        }

        Console.WriteLine("========= LISTA ===========");
        foreach(KeyValuePair<int, string> item in veiculo) {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
        Console.WriteLine("========= LISTA ===========");
        // Outra formar
        Dictionary<int, string>.ValueCollection valores = veiculo.Values;
        foreach(string item in valores) {
            Console.WriteLine("{0}", item);
        }
    }
}