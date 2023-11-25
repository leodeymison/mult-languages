using System;

class Primary {
    static void Main(){
        float nota = 2.0f;

        if(nota >= 7.0) {
            Console.WriteLine("Resultado: APROVADO");
        } else if (nota < 7.0 && nota >= 3) {
            Console.WriteLine("Resultado: RECUPERAÇÃO");
        } else {
            Console.WriteLine("Resultado: REPROVADO");
        }
    }
}