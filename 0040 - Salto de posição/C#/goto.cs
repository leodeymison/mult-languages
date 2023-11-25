using System;

class Primary {
    static void Main() {
        string messageReturn = "Tempo estimado para a viagem é de";

        start:
        
        Console.Clear();

        Console.WriteLine("Selecione uma opção para sua viagem:");
        Console.WriteLine("Digite A para Avião");
        Console.WriteLine("Digite C para Carro");
        Console.WriteLine("Digite O para ônibus");
        Console.Write("> ");
        char option = char.Parse(Console.ReadLine());

        switch (option) {
            case 'A':
            case 'a':
                Console.WriteLine("{0} 15 minutos", messageReturn);
                break;
            
            case 'C':
            case 'c':
                Console.WriteLine("{0}, 1 hora", messageReturn);
                break;

            case 'O':
            case 'o':
                Console.WriteLine("{0} 2 horas e  5 minutos", messageReturn);
                break;
            
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.Write("Deseja calcular outro transporte: [S/N]");
        char continueProgram = char.Parse(Console.ReadLine());

        if(continueProgram == 'S' || continueProgram == 's') {
            goto start;
        } else if (continueProgram == 'N' || continueProgram == 'n') {
            Console.Clear();
            Console.WriteLine("Aplicativo finalizado!");
            Environment.Exit(0);
        } else {
            goto start;
        }
    }
}