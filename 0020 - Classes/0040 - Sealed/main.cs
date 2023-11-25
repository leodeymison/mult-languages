using System;

sealed class Player { // Não pode ser herdada
    public void info(){
        Console.WriteLine("Hello world!");
    }
}

class Project {
    static void Main(){
        Player pl1 = new Player();
        pl1.info();
    }
}