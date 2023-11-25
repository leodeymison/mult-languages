using System;

class Primary {
    static void Main(){
        int num = 10;

        Console.WriteLine(num << 1); // 20 => Dobra uma vez
        Console.WriteLine(num << 2); // 40 => Dobra duas vezes

        Console.WriteLine(num >> 1); // 5  => Divide pela medate um vez
        Console.WriteLine(num >> 2); // 2  => Divide pela medate duas vezes
    }
}