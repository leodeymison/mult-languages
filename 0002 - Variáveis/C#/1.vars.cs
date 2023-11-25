using System;

class Primary {
    static void Main(){
        byte n1 = 10; // Entre 0 e 255 | 8 bits
        int num = 0;
        char caracter = 'a';
        float valor = 3.1f;
        string text = "Hello world";

        var aux = 0; // Recebe o tipo pela atribuição

        Console.WriteLine("Byte: " + n1);
        Console.WriteLine(num);
        Console.WriteLine(caracter);
        Console.WriteLine(valor);
        Console.WriteLine(text);
        Console.WriteLine(aux);
    }
}