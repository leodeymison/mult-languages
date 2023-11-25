using System;

class Primary {
    static void Main(){
        string message = "Olá mundo!";

        // Console.Write(message + " Hoje é 11 de outubro de 2023.\n");
        // Console.WriteLine(message + " Hoje é 11 de outubro de 2023.");
        // Console.Write("\t{0} Hoje é 11 de outubro de 2023.\n", message);
        // Console.WriteLine("{0} Hoje é 11 de outubro de 2023.", message);


        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string nome = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto... {0,15}", nome);
        Console.WriteLine("Valor..... {0,15:c}", valorCompra);
        Console.WriteLine("Lucro..... {0,15:p}", lucro);
        Console.WriteLine("Venda..... {0,15:c}", valorVenda);
    }
}