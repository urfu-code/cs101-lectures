using System;

namespace Slide03
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


        public static void MainX()
        {
            var str=Console.ReadLine();
            //Конверсия строки в enum происходит так:
            var season=(Seasons)Enum.Parse(typeof(Seasons),str);
            //Обратная - как и всегда, с помощью ToString()
            Console.WriteLine(season.ToString());
        }
    }
}