using System;

class Calculator {
    static void Main(){
        menu();
        int option = int.Parse(Console.ReadLine());
        int value1 = 0, value2 = 0;
        Console.Write("Digite o primeiro valor: ");
        value1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        value2 = int.Parse(Console.ReadLine());

        if(option == 1) {
            somar(value1, value2);
        }
        if(option == 2) {
            Subtrair(value1, value2);
        }
        if(option == 3) {
            multiplicar(value1, value2);
        }
        if(option == 4) {
            dividir(value1, value2);
        }
    }

    static void somar(int value1, int value2) {
        Console.WriteLine("{0} + {1} = {2}", value1, value2, value1 + value2);
    }

    static void Subtrair(int value1, int value2) {
        Console.WriteLine("{0} - {1} = {2}", value1, value2, value1 - value2);
    }

    static void multiplicar(int value1, int value2) {
        Console.WriteLine("{0} X {1} = {2}", value1, value2, value1 * value2);
    }

    static void dividir(int value1, int value2) {
        Console.WriteLine("{0} : {1} = {2}", value1, value2, value1 / value2);
    }

    static void menu(){
        Console.WriteLine("=========================================");
        Console.WriteLine("================ CALCULATOR =============");
        Console.WriteLine("=========================================");
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Selecione um opção: ");
    }
}