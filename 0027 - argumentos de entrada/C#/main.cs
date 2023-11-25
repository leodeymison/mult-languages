using System;
using System.Linq;

class Project {
    static void Main(string[] args){
        string[] valid = new string[]{"-p", "-a", "-g"};
        if(args.Length > 0) {
            foreach(string item in args) {
                if(!valid.Any(element => element == item)) {
                    throw new Exception($"Invalid argument {item}");
                }
            }
            Console.WriteLine("Nenhum erro encontrado nos argumentos");
        } else {
            Console.WriteLine("Nenhum argumento");
        }
    }
}