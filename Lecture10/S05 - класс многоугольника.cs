using System;

namespace Slide05
{
    public class Point
    {
        public double X;
        public double Y;
    }

    /* А так еще лучше.
     * Теперь у нас не просто массив точек, а многоугольник, у которого есть периметр.
     */
    public class Polygon
    {
        public Point[] Points;
        public double GetPerimeter()
        {
            double length = 0;
            for (int i = 0; i < Points.Length; i++)
                length += Math.Sqrt(
                    Math.Pow(Points[i].X - Points[(i + 1) % Points.Length].X, 2) +
                    Math.Pow(Points[i].Y - Points[(i + 1) % Points.Length].Y, 2));
            return length;
        }
    }

    /* А вот, например, ломаная. Она тоже строится на базе массива точек, но периметра у нее нет.
     * Есть длина, и считается она немного по-другому.
     * Теперь мы никогда случайно не перепутаем периметр с длиной ломаной! Будет физически невозможно посчитать "длину" многоугольника
     * или "периметр" ломаной
     */
    public class Polyline
    {
        public Point[] Points;
        public double GetLength()
        {
            double length = 0;
            for (int i = 0; i < Points.Length-1; i++)
                length += Math.Sqrt(
                    Math.Pow(Points[i].X - Points[i + 1].X, 2) +
                    Math.Pow(Points[i].Y - Points[i + 1].Y, 2));
            return length;
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var poly = new Polygon();
            poly.Points = new Point[4];
            poly.Points[0] = new Point();
            poly.Points[0].X = 0;
            poly.Points[0].Y = 0;
            //Вы должны очень хорошо понимать, что происходит в куче, когда вы выполняете эти действия!

            //Чем больше класс, тем элегантнее его сокращенная инициализация
            var poly1 = new Polygon
            {
                Points = new Point[]
                {
                    new Point { X=0, Y=0 },
                    new Point { X=1, Y=0 },
                    new Point { X=1, Y=1 },
                    new Point { X=0, Y=1 },
                }
            };
                    




        }
    }
}