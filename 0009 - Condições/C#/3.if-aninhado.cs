using System;

class Primary {
    static void Main(){
        float nota = 2.0f;

        if(nota >= 7.0) {
            if(nota < 9) {
                Console.WriteLine("APROVADO com nota COMUM");
            } else {
                Console.WriteLine("APROVADO com nota ALTA");
            }
        } else if (nota >= 3 && nota < 7) {
            Console.WriteLine("RECUPERAÇÂO");
        } else {
            Console.WriteLine("REPROVADO");
        }
    }
}