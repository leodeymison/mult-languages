using Internal;
using System;

class Veiculo {
    public int velMax;
    public bool ligado;
    public string color;

    public Veiculo(string color, int velMax){
        this.color = color;
        this.velMax = velMax;
    }

    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
}
class Carro: Veiculo {
    public string model;
    public Carro(string model, string color, int velMax):base(color, velMax) {
        this.model = model;
        this.color = color;
        this.velMax = velMax;
    }

    public void info(){
        Console.WriteLine("Cor......: {0}", this.color);
        Console.WriteLine("V. máxima: {0}", this.velMax);
        Console.WriteLine("Ligado...: {0}", this.ligado ? "Sim" : "Não");
        Console.WriteLine("Model...:  {0}", this.model);
    }
}

class Ferrari: Carro {
    public Ferrari(string color, int velMax, string model):base(model, color, velMax) {
        this.model = model;
        this.color = color;
        this.velMax = velMax;
    }
}
class Primary {
    static void Main(){
        Carro c1 = new Ferrari("red", 400, "Ferrari");
        c1.ligar();
        c1.info();
    }
}