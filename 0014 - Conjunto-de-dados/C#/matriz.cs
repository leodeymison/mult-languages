using System;

class Primary {
    static void Main(){
        int[,] list1 = new int[3, 3];
        int[,] list2 = new int[2, 2]{{31, 22}, {4, 7}};
        int[,] list3 = {{12, 25}, {23, 56}};
        int[,,] list4 = new int[2, 2, 2];
        int[,,] list5 = new int[2, 2, 2]{{{23, 34}, {11, 22}},{{77, 79}, {76, 12}}};
        int[,,] list6 = {{{23, 34}, {11, 22}}, {{77, 79}, {76, 12}}};

        list4[0, 0, 0] = 23;
        list4[0, 0, 1] = 34;
        list4[0, 1, 0] = 11;
        list4[0, 1, 1] = 22;
        list4[1, 0, 0] = 77;
        list4[1, 0, 1] = 79;
        list4[1, 1, 0] = 76;
        list4[1, 1, 1] = 12;

        list1[0, 0] = 10;
        list1[0, 1] = 23;
        list1[0, 2] = 12;
        list1[1, 0] = 22;
        list1[1, 1] = 45;
        list1[1, 2] = 34;
        list1[2, 0] = 90;
        list1[2, 1] = 11;
        list1[2, 2] = 46;

        Console.WriteLine(list6[1, 1, 1]);
    }
}