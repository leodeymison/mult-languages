using Internal;
using System;

class Mat {
    public static float pi=3.14f;

    public static int dobro(int num) {
        return num * 2;
    }
}

class Project {
    static void Main(){
        int value = 10;
        Console.WriteLine("PI..........: {0}", Mat.pi);
        Console.WriteLine("Dobro de  {0}: {1}", value, Mat.dobro(value));
    }
}