using System;

public interface VehicleModel {
    void ChangeOn();
    void ChangeOff();
}

class Vehicle : VehicleModel {
    private bool status = false;

    public bool infoStatus {
        get {
            return this.status;
        }
    }

    public void ChangeOn() {
        this.status = true;
    }
    public void ChangeOff(){
        this.status = false;
    }
}

class Project {
    static void Main(){
        Vehicle car = new Vehicle();

        car.ChangeOn();

        Console.WriteLine("O carro está ligado? {0}", car.infoStatus ? "SIM" : "NÃO");

        car.ChangeOff();

        Console.WriteLine("O carro está ligado? {0}", car.infoStatus ? "SIM" : "NÃO");
    }
}