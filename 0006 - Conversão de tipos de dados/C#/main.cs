using System;

class Primary {
    static void Main(){
        // ? Conversão segura (Implicita)
        // int value1 = 10;
        // float value2 = value1;
        // Console.WriteLine(value2); => 10

        // ! Não é possível converter tipo float em int implicitamente

        // ? Conversão explicita (type cast)
        float vl1 = 5.5f;
        int vl2 = (int)vl1;
        Console.WriteLine(vl2);
    }
}