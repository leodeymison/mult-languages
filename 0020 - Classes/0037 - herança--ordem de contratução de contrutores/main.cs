using Internal;
using System;

class Base1 {
    public Base1(){
        Console.WriteLine("Construtor 1");
    }
}

class Base2: Base1 {
    public Base2(){
        Console.WriteLine("Construtor 2");
    }
}

class Base3 : Base2 {
    public Base3(){
        Console.WriteLine("Construtor 3");
    }
}

class Primary {
    static void Main(){
        new Base3();
    }
}