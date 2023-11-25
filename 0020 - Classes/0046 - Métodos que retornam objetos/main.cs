using Internal;
using System;

class Galinha {
    private string nameGalinha;
    private int numberOvos;
    public Galinha(string nameGalinha){
        this.nameGalinha = nameGalinha;
        this.numberOvos = 0;
    }
    public Ovo botar(){
        this.numberOvos++;
        return new Ovo(this.nameGalinha);
    }
    public string changeOvos {
        get {
            string pural = "ovo";
            if(this.numberOvos > 1) {
                pural = "ovos";
            };
            return $"Galinha {nameGalinha} tem {numberOvos} {pural}";
        }
    }
}
class Ovo {
    public Ovo(string name){
        Console.WriteLine("{0} - Ovo criado!", name);
    }
}

class Project {
    static void Main(){
        Galinha galinha1 = new Galinha("Benedita");
        Galinha galinha2 = new Galinha("larissa");
        Galinha galinha3 = new Galinha("Pedrinha");

        galinha1.botar();
        Console.WriteLine(galinha1.changeOvos);
        galinha1.botar();
        galinha1.botar();
        Console.WriteLine(galinha1.changeOvos);
    }
}