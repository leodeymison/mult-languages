using System;

class Player {
    public int life = 100;
    private bool lived = true;
    
    public bool setLived(){
        return lived;
    }
}
class Primary {
    static void Main(){
        Player p1 = new Player();

        Console.WriteLine("Vida: {0}", p1.life);
        Console.WriteLine("vido: {0}", p1.setLived() ? "Sim" : "Não");
    }
}