using System;

class Primary {
    static void Main(){
        string textResponse = "Você chegará em";
        Console.WriteLine("Qual transporte você deseja viajar? ");
        Console.WriteLine("Digite A para avião");
        Console.WriteLine("Digite C para carro");
        Console.WriteLine("Digite O para ônibus");
        Console.Write("> ");
        char trans = char.Parse(Console.ReadLine());

        switch(trans){
            case 'A':
            case 'a':
                Console.WriteLine("{0} 15 minutos", textResponse);
                break;

            case 'C':
            case 'c':
                Console.WriteLine("{0} 1 horas e 20 minutos", textResponse);
                break;
                
            case 'O':
            case 'o':
                Console.WriteLine("{0} 3 horas e 5 minutos", textResponse);
                break;

            default:
                Console.WriteLine("Não existe essa opção!");
                break;
        }
    }
}