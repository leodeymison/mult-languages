using System;

class Primary {
    static void Main(){
        // SEU NOME
        Console.Write("Digite o seu nome: ");
        string name = Console.ReadLine();
        Console.Write("Digite a idade: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome....: {0, 15}", name);
        Console.WriteLine("Idade...: {0, 15}", year);

        // SOMA
        Console.Write("Valor 1: ");
        int value1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A soma de {0} mais {1} é {2}", value1, value2, value1 + value2);
    }
}