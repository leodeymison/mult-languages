using System;

class Primary {
    static void Main(){
        float[] list = {23, 45, 34, 556, 23234, 123, 902, 232};
        int i = 0;
        while(i < list.Length){
            Console.WriteLine(list[i] / 2);
            i++;
        }
    }
}