using System;

class Primary {
    static void Main(){
        Soma(10, 45);
    }

    static void Soma(params int[] numbers){
        int result = 0;
        for(int i=0; i<numbers.Length; i++){
            result += numbers[i];
        }
        Console.WriteLine(result);
    }
}