using System;

namespace Slide02
{
    public enum Seasons
    {
        /*
         * Можно задать соответствующие значениям перечисления числовые константы. 
         * Значения произвольные и идут в произвольном порядке. 
         *  По умолчанию они 0,1,2,... 
         */
        Winter=1, 
        Spring=2,
        Summer=3,
        Fall=0
    }
        
    public class Program
    {

        //перечисление - это полноценный тип данных, он может быть использован при объявлении переменной, в сигнатуре метода, и т.д.
        static  double GetDiscount(Seasons season)
        {
            //Переменная season принимает одно из значений Seasons.Winter, Seasons.Spring,  Seasons.Summer, Seasons.Fall  
            if (season == Seasons.Summer) return 0;
            else return 0.5;
        }

        public static void MainX()
        {
            Seasons season = Seasons.Summer;
            // int seasonNumber = season;   // Неявной конверсии нет!
            int seasonNumber = (int)season; // Явная конверсия есть
            //GetDiscount(seasonNumber); // Так тоже нельзя, неявной конверсии по-прежнему нет!
            GetDiscount((Seasons)seasonNumber); //Так можно
            season = (Seasons)(seasonNumber + 1); //Ошибки рантайма нет, но season не равна ни одному из четырех значений!
        }
    }
}