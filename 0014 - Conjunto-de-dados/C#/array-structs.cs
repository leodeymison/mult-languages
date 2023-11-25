using Internal;
using System;

class Vehicle {
    private string model;
    private string color;

    public Vehicle(string model, string color) {
        this.model = model;
        this.color = color;
    }
    public void info(){
        Console.WriteLine("Modelo..: {0}", this.model);
        Console.WriteLine("Cor.....: {0}", this.color);
        Console.WriteLine("=============================");
    }
}

class Project {
    static void Main(){
        Vehicle[] list = {
            new Vehicle("Ferrari", "red"),
            new Vehicle("Lamborghini", "blank")
        };

        list[0].info();
        list[1].info();
    }
}