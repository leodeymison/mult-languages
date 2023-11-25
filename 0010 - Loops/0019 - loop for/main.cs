using System;

class Primary {
    static void Main(){
        int[] list = {23, 45, 90, 234, 3432, 123, 999};

        for(int i = 0; i < list.Length; i++) {
            int index = i+1;
            Console.WriteLine(list[i] / 2);
        }
    }
}