using System;

static class Player1 {
    static public int life = 100;
    static public bool alive = true;

    static public void info(){
        Console.WriteLine("Player type one");
        Console.WriteLine("Vida: {0}", life);
        Console.WriteLine("Vivo: {0}", (alive ? "Sim" : "Não"));
    }
}

public class Player2 {
    public int life = 100;
    static public bool alive;

    public string name;

    public Player2(string name, bool al){
        this.name = name;
        alive = al;
    }

    public void info(){
        Console.WriteLine("======================================================");
        Console.WriteLine("Nome: {0}", name);
        Console.WriteLine("Vida: {0}", life);
        Console.WriteLine("Vivo: {0}", (alive ? "Sim" : "Não"));
    }
}

class Primary {
    static void Main(){
        Player1.info();

        Player2 p1 = new Player2("Pedro", true);
        p1.info();
        Player2 p2 = new Player2("João", true);
        p2.info();

        Player2.alive = false; // Muda de todos pois é static e tem um único indereço de memória
        p1.info();
        p2.info();
    }
}