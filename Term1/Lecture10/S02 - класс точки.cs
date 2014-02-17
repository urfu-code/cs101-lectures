using System;

namespace Slide02
{
    /* Здесь мы объявляем класс Point.
     * Как и любой тип данных, класс определяет формат хранения информации.
     * В этом случае, он определяет формат "точки" как "пары чисел".
     */
    public class Point
    {
        // Переменная, определенная внутри классе, называется "полем"
        public double X;
        //Пишите public всегда - перед названием полей, методов и классов.
        public double Y;
    }

    public class Program
    {
        public static void MainX ()
        {
            /* Здесь мы создаем переменную point1 класса Point
             * То есть - два числа
             */
            var point1 = new Point();
            point1.X = 10;
            point1.Y = 10;

            // Здесь мы делаем то же самое, используя сокращенный синтаксис
            var point2 = new Point
            {
                X = 10,
                Y = 10
            };


        }
    }
}