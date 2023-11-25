using System;

namespace Calc {
    class Area {
        public static float Quadrado(float bas, float alt) {
            if(bas == 0 || alt == 0) {
                throw new Exception("Base e altura não podem ser zero"); 
            }
            return bas * alt;
        }
    }
}

class Project {
    static void Main(){
        try {
            float n1 = 3f;
            float n2 = 3f;
            float res = Calc.Area.Quadrado(n1, n2);
            Console.WriteLine("{0}X{1} = {2}m/4", n1, n2, res);
        } catch (Exception error) {
            Console.WriteLine("Erro ao dividir valores: {0}", error);
        } finally {
            Console.WriteLine("Fim do processo");
        }
    }
}