using Internal;
using System;
class Vehicle {
    private int topSpeed;

    public Vehicle(){
        this.topSpeed = 100;
    }

    public int ChangeTopSpeed {
        get {
            return topSpeed;
        } 
        set {
            topSpeed = value;
        }
    }
}

class Project {
    static void Main(){
        Vehicle car = new Vehicle();
        Console.WriteLine(car.ChangeTopSpeed);
        car.ChangeTopSpeed = 120;
        Console.WriteLine(car.ChangeTopSpeed);
    }
}