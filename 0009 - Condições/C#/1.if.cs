using System;

class Primary {
    static void Main(){
        float nota = 2.9f;

        if(nota >= 7.0) {
            Console.WriteLine("Resultado: APROVADO");
        }
        if(nota < 3.0) {
            Console.WriteLine("Resultado: REPROVADO");
        }
        if(nota >= 3.0 & nota < 7.0) {
            Console.WriteLine("Resultado: RECUPERAÇÃO");
        }
    }
}