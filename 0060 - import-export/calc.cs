using System;

namespace MethodsCalc {
    class Calc {
        public int somar(params int[] ints) {
            int result = 0;

            foreach(int item in ints) {
                result += item;
            }

            return result;
        }
    }
}