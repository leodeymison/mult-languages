using System;

class Vehicle {
    private int[] topSpeed = new int[5]{23, 34, 455, 23, 344};

    public int this[int index] {
        get {
            return topSpeed[index];
        }
        set {
            this.topSpeed[index] = value;
        }
    }
}

class Project {
    static void Main(){
        Vehicle car = new Vehicle();
        Console.WriteLine(car[0]);
        car[0] = 100;
        Console.WriteLine(car[0]);
    }
}