using System;

namespace Slide03
{

    public class Point
    {
        public double X;
        public double Y;

        /* Empty отмечено словом static. Поэтому Empty - уникально, оно одно для всей вашей программы.*/
        public static Point Empty = new Point { X = 0, Y = 0 };
    }

    public class Program
    {
        //Обратите внимания, что точка входа - тоже уникальна. Она может быть только одна.
        public static void MainX()
        {
            //Обращение к уникальному  идет через имя ТИПА, а не класса
            Console.WriteLine(Point.Empty.X);

            // Console.WriteLine(Point.X); // А так писать нельзя, потому что координата X - не одна на всех, а своя у каждой точки

            //Обратите внимание, что WriteLine, и вообще Console - она одна на всех!
            Console.WriteLine(4);

            //Так же как и синус, и вообще вся математика.  
            Console.WriteLine(Math.Sin(1));

            //Метод Parse - уникальный, он один на всю программу
            var number = int.Parse("123");

            //А вот метод ToString ведет себя по-разному для каждого числа, и поэтому он не уникальный
            Console.WriteLine(number.ToString());

            /* ИТОГО:
             * Когда что-то (метод, поле или целый класс) одни на всю программу, оно помечаются словом static.
             * Когда "что-то" - свое у каждого экземпляра, то  static не пишется.
             */
        }
    }
}