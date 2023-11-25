using Internal;
using System;

class Calc {
    public int soma(int n1, int n2){
        Console.WriteLine("Soma entre 2 valores inteiros");
        return n1 + n2;
    }
    public double soma(double n1, double n2, double n3){
        Console.WriteLine("Soma entre 3 valores double");
        return n1 + n2 + n3;
    }
    public double soma(params int[]list){
        Console.WriteLine("Soma entre ints infinitos");
        int res = 0;
        foreach(int item in list){
            res += item;
        }
        return res;
    }
    public double soma(params double[]list){
        Console.WriteLine("Soma entre doubles infinitos");
        double res = 0;
        foreach(double item in list){
            res += item;
        }
        return res;
    }
}
class Project {
    static void Main(){
        Calc ca = new Calc();

        Console.WriteLine(ca.soma(12, 23));
        Console.WriteLine(ca.soma(12, 23, 23.23));
        Console.WriteLine(ca.soma(12, 23, 11, 50, 34, 90));
        Console.WriteLine(ca.soma(12, 23, 11.3, 50, 34.12, 90));
    }
}