using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class Point
    {
        public int X;
        public int Y;
    }

    static class PointStackExtensions
    {
        public static void Push(this Stack<Point> stack, int x, int y)
        {
            stack.Push(new Point { X = x, Y = y });
        }

    }

    class S06
    {
        static Space[,] map;

        static bool CanMove(int x, int y)
        {
            return x >= 0 && y >= 0 && x < map.GetLength(0) && y < map.GetLength(1) && map[x, y] == Space.NotVisited;
        }

        static void Visualize()
        {
            Console.Clear();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                    Console.Write(
                        map[x, y] == Space.Wall ? '#' : (map[x,y]== Space.Visited ? '+' : ' ')
                        );
                Console.WriteLine();
            }
                Console.ReadKey(true);
        }

        static void Go(int x, int y)
        {
            if (!CanMove(x, y)) return;
            map[x, y] = Space.Visited;
            //Visualize();
            Go(x - 1, y);
            Go(x + 1, y);
            Go(x, y - 1);
            Go(x, y + 1);
        }

        public static void MainX()
        {
            map = Labirynth.CreateLarge();
            Stack<Point> points = new Stack<Point>();
            points.Push(new Point { X = 0, Y = 0 });

            while (points.Count!=0)
            {
                var point = points.Pop();
                if (!CanMove(point.X, point.Y)) continue;
                map[point.X, point.Y] = Space.Visited;
               // Visualize();
                points.Push(point.X - 1, point.Y);
                points.Push(point.X + 1, point.Y);
                points.Push(point.X, point.Y - 1);
                points.Push(point.X, point.Y + 1);

            }

        }
    }
}
