using System;

class Calculo {
    public int n1;
    public int n2;
    
    public Calculo(int n1, int n2) {
        this.n1 = n1;
        this.n2 = n2;
    }
    public int somar(){
        return this.n1 + this.n2;
    }
}
class Primary {
    static void Main(){
        Console.WriteLine(new Calculo(12, 10).somar());
    }
}