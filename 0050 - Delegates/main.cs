using Internal;
using System;

delegate int OP(int n1, int n2);
class Mat {
    public static int somar(int n1, int n2) {
        return n1 + n2;
    }
    public static int multi(int n1, int n2) {
        return n1 * n2;
    }
}

class Project {
    static void Main(){
        OP operation = new OP(Mat.multi);

        Console.WriteLine(operation(10, 20));
        
        operation = new OP(Mat.somar);
        Console.WriteLine(operation(10, 20));
    }
}