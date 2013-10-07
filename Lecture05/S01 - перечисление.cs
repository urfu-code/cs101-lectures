using System;

namespace Slide01
{
    //Так объявляются перечисления
    public enum Seasons
    {
        Winter,
        Spring,
        Summer,
        Fall
    }
        
    public class Program
    {

        //перечисление - это полноценный тип данных, он может быть использован при объявлении переменной, в сигнатуре метода, и т.д.
        static double GetDiscount(Seasons season)
        {
            //Переменная season принимает одно из значений Seasons.Winter, Seasons.Spring,  Seasons.Summer, Seasons.Fall  
            if (season == Seasons.Summer) return 0;
            else return 0.5;
        }

        public static void Main()
        {
            //Переменная типа Seasons
            Seasons season = Seasons.Fall;
            Console.WriteLine(GetDiscount(season));
        }
    }
}