using System;

namespace Slide03
{
    public class Program
    {
        public static void MainX()
        {
            //Сравнение тоже имеет возвращаемое значение
            Console.WriteLine(5 < 4);

            //И его можно сохранить в переменную
            bool comparisonResult = 6 >7;
            Console.WriteLine(comparisonResult);

            //Константы истины и лжи
            bool trueValue=true;
            bool falseValue=false;

            //И даже вернуть из метода
            Console.WriteLine(ComparisonMethod(5,6));

            //Все операции сравнения
            Console.WriteLine(5 == 6);
            Console.WriteLine(5 != 6);
            Console.WriteLine(5 < 5);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 5);


        }

        static bool ComparisonMethod(int argument1, int argument2)
        {
            return argument1 < argument2;
        }
    }
}