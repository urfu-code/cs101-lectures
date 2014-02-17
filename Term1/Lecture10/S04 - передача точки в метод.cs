using System;

namespace Slide04
{

    public class Point
    {
        public double X;
        public double Y;
    }


    public class Program
    {
        /*
         * Теперь совершенно понятно, что в метод нужно передавать массив точек,
         * а не два массива непонятно чего
         */
        static double GetPerimeter(Point[] points)
        {
            double length = 0;
            for (int i = 0; i < points.Length; i++)
                length += Math.Sqrt(
                    Math.Pow(points[i].X - points[(i + 1) % points.Length].X, 2) +
                    Math.Pow(points[i].Y - points[(i + 1) % points.Length].Y, 2));
            return length;
        }

        public static void MainX()
        {
            //А здесь я совмещаю сокращенную инициализацию массива и объекта
            Console.WriteLine(GetPerimeter(new Point[]
            {
                new Point { X=0, Y=0 },
                new Point { X=1, Y=0 },
                new Point { X=1, Y=1 },
                new Point { X=0, Y=1 }
            }));

        }
    }
}