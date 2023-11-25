using System;

abstract class PlayerModel {
    abstract public void info();
}

class Player: PlayerModel {
    private string name;
    public Player(string name) {
        this.name = name;
    }
    override public void info(){
        Console.WriteLine("Nome: {0}", this.name);
    }
}

class Project {
    static void Main(){
        Player player1 = new Player("Pedro");
        player1.info();
    }
}