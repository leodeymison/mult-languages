using Internal;
using System;

class Calc {
    public int fat(int num){
        int res;
        if(num < 1) {
            res = 1;
        } else {
            res = num * fat(num - 1);
        }
        return res;
    }
}

class Project {
    static void Main(){
        Calc cl = new Calc();
        Console.WriteLine(cl.fat(3));
    }
}