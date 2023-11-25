using Internal;
using System;

class Vehicle {
    protected int speedCurrent;
    private int topSpeed;
    protected bool on; 
    protected Vehicle (int topSpeed){
        this.speedCurrent = 0;
        this.topSpeed = topSpeed;
        this.on = false;
    }
    protected int getTopSpeed(){
        return this.topSpeed;
    }
}

class Car: Vehicle {
    public Car(int topSpeed):base(topSpeed) {}

    public void info(){
        Console.WriteLine("Velocidada máxima: {0}km/h", this.getTopSpeed());
        Console.WriteLine("Ligado...........: {0}", this.on ? "Sim" : "Não");
        Console.WriteLine("Velocidade atual.: {0}km/h", this.speedCurrent);
        Console.WriteLine("================================", this.getTopSpeed());
    }
    public void ChangesUpSpeedCurrent(){
        if(this.speedCurrent < this.getTopSpeed() && this.on) {
            this.speedCurrent++;
        }
    }
    public void ChangesDownSpeedCurrent(){
        if(this.speedCurrent > 0 && this.on) {
            this.speedCurrent--;
        }
    }
    public void onCar(){
        this.on = true;
    }
    public void offCar(){
        this.on = false;
    }
}

class Primary {
    static void Main(){
        Car car1 = new Car(100);
        car1.onCar();
        car1.info();
        Console.WriteLine("Add 110");
        for(int index = 0; index < 110; index++) {
            car1.ChangesUpSpeedCurrent();
        }
        car1.info();
        Console.WriteLine("Remove 1");
        car1.ChangesDownSpeedCurrent();
        car1.info();
        Console.WriteLine("Remove 110");
        for(int index = 0; index < 110; index++) {
            car1.ChangesDownSpeedCurrent();
        }
        car1.info();
    }
}