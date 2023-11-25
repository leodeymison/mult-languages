using Internal;
using System;
using System.Collections.Generic;

class Player {
    public string name;
    public object fire;
    public Player(string name, object fire) {
        this.name = name;
        this.fire = fire;
    }
}

class Arena {
    public int Fire(){
        Console.WriteLine("Atirar");
        return 1;
    }
}

class Program {
    static void Main(){
        List<Player> test = new List<Player>();
        Arena arenaLeague = new Arena();

        test.Add(new Player("Pedro", arenaLeague.Fire()));
    }    
}