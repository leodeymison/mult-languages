using System;

class Primary {
    static void Main(){
        int value = 10;
        dobrar(ref value);
        Console.WriteLine(value);
    }

    static void dobrar(ref int value){ // ref => Pega o endereço da memória da variável passada
        value *= 2;
    }
}
