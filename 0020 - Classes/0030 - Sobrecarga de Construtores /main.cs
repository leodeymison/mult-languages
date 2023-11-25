using Internal;
using System;

class Player {
    public int energia;
    public bool vivo;
    public string name;

    public Player(string nm){
        name = nm;
        energia = 100;
        vivo = true;
    }
    public Player(string nm, int ener){
        name = nm;
        energia = ener;
        vivo = true;
    }
    public void info(){
        Console.WriteLine("=================");
        Console.WriteLine("Name:....: {0}", name);
        Console.WriteLine("Energia:.: {0}", energia);
        Console.WriteLine("Vivo?....: {0}", vivo);
        Console.WriteLine("=================");
    }
    public void info(bool viewVivo){
        Console.WriteLine("=================");
        Console.WriteLine("Name:....: {0}", name);
        Console.WriteLine("Energia:.: {0}", energia);
        if(viewVivo){
           Console.WriteLine("Vivo....: {0}", vivo); 
        }
        Console.WriteLine("=================");
    }
}

class Primary {
    static void Main(){
        Player joao = new Player("João");
        Player pedro = new Player("Pedro", 80);

        joao.info();
        pedro.info(false);
    }
}