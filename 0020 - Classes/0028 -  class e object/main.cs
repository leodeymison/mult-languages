using System;

class Player {
    public int life = 100;
    public bool alive = true;
}
class Primary {
    static void Main(){
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();

        Console.WriteLine("Vida: {0} | Vivo: {1}", player1.life, player1.alive);
    }
}