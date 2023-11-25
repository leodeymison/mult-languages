using System;

class Primary {
    static void Main(){
        int[] list1 = new int[3];
        int[] list2 = new int[2];
        int[] list3 = new int[3];
        int[,] list4 = new int[2, 2]{{23, 34}, {45, 34}};

        Random rand = new Random();
        for(int i = 0; i < list1.Length; i++) {
            list1[i] = rand.Next(50); // 0 a 49
            // Console.WriteLine(list1[i]);
        }

        // * Binary search
        int search = 50;
        list1[2] = search;
        int response = Array.BinarySearch(list1, search);
        // Console.WriteLine("Número {0} está na posição: {1}", search, response);

        // * COPY
        Array.Copy(list1, list2, list1.Length - 1);
        // Console.WriteLine(list2[1]);

        // * CopyTo
        list1.CopyTo(list3, 0); // 0 = Copia a partir do 0
        // Console.WriteLine(list3[2]);

        // * Pegar valor de um index
        int value = Convert.ToInt32(list1.GetValue(2)); // GetValue = return object
        // Console.WriteLine(value);

        // * Index Of // Encontra a posição do primeiro valor passado
        list1[0] = 10;
        list1[2] = 10;
        int position1 = Array.IndexOf(list1, 10);
        // Console.WriteLine(position1);

        // * Last Index Of // Encontra a posição do ultimo valor passado
        int position2 = Array.LastIndexOf(list1, 10);
        // Console.WriteLine(position2);

        // * Reverse // Investe a ordem dos elementos
        list1[0] = 1;
        list1[2] = 2;
        Array.Reverse(list1);
        // Console.WriteLine(list1[2]);

        // * SetValue // Muda um valor em uma posição
        int[] index1 = {12, 23, 45, 56};
        index1.SetValue(15, 0); // add 12 in position 0
        // Console.WriteLine(index1[0]); // 15
        // Console.WriteLine(index1[1]); // 23

        // * Sort // Ordena o array
        list1[0] = 23; 
        list1[1] = 1;
        list1[2] = 50;
        Array.Sort(list1);
        // Console.WriteLine(list1[0]);
        // Console.WriteLine(list1[1]);
        // Console.WriteLine(list1[2]);
    }
}