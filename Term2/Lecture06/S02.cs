using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02
{
    class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("X:{0} Y:{1}", X, Y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Point)) return false;
            var point2 = (Point)obj;
            return X == point2.X && Y == point2.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }

    }

    class Program
    {
        public static void MainX()
        {
            var list = new List<Point>();
            var point = new Point(0, 0);
            var point1 = new Point(0, 0);

            Console.WriteLine(point);

            list.Add(point);
            Console.WriteLine(list.Contains(point));
            Console.WriteLine(list.Contains(point1));

            Console.WriteLine(point == point1);

            var dict = new Dictionary<Point, int>();
            dict[point] = 1;
            Console.WriteLine(dict[point]);
            Console.WriteLine(dict[point1]);
        }
    }
}
