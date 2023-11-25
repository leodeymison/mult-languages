using System;

class Primary {
    enum DaysSemana{
        Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
    };
    static void Main(){
        DaysSemana PrimaaryDay = (DaysSemana)0;

        DaysSemana CurrentDay = DaysSemana.Quinta;

        int IndexCurrent = (int)DaysSemana.Quinta;


        Console.WriteLine("Primary day is {0}", PrimaaryDay);
        Console.WriteLine("Current day is {0}", CurrentDay);
        Console.WriteLine("Index the in current day is {0}", IndexCurrent);
    }
}