using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01
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
    }

    class Program
    {
        public static void MainX()
        {
            var list = new List<Point>();
            var point = new Point(0, 0);
            list.Add(point);
            Console.WriteLine(
                list.Contains(point));
            Console.WriteLine(
                list.Contains(new Point(0, 0)));

            var dict = new Dictionary<Point, int>();
            dict[point] = 1;
            Console.WriteLine(dict[point]);
            Console.WriteLine(dict[new Point(0, 0)]);
        }
    }
}
