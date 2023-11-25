using Internal;
using System;

public class Player {
    public int life;
    public bool alive;

    public Player(int vida, bool vivo){ // contructor
        life = vida;
        alive = vivo;
    }
    ~Player(){ // destructor
        Console.WriteLine("Jogador foi removido");
    }
}
class Primary {
    static void Main(){
        Player player1 = new Player(100, true);
        Console.WriteLine(player1.life);
        Player player2 = new Player(45, true);
        Console.WriteLine(player2.life);
    }
}