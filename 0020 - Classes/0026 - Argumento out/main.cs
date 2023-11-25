using System;

class Primary {
    static void Main(){
        int resto = 0;
        int response = divide(20, 3, out resto);
        Console.WriteLine(response);
        Console.WriteLine(resto);
    }

    static int divide(int n1, int n2, out int resto){ // Método de saída
        resto = n1 % n2;
        return n1 / n2;
    }
}