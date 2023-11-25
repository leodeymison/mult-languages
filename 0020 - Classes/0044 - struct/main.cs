using System;

struct Vehicle {
    public string marca;
    public string model;
    public string color;
    public Vehicle(string marca, string model, string color){
        this.marca = marca;
        this.model = model;
        this.color = color;
    }
}

class Project {
    static void Main(){
        Vehicle car;
        // Vehicle car = new Vehicle("Ferrari", "La Ferrari", "white");

        car.marca = "Ferrari";
        car.model = "La Ferrari";
        car.color = "white";

        Console.WriteLine("Marca.: {0}", car.marca);
        Console.WriteLine("Modelo: {0}", car.model);
        Console.WriteLine("Cor...: {0}", car.color);
    }
}