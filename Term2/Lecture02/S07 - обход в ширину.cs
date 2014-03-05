using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace S07
{

    class Point
    {
        public int X;
        public int Y;
    }

    class Program
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
                //Console.ReadKey(true);
            Thread.Sleep(100);
        }

        
        public static void Main()
        {
            map = Labirynth.CreateLabirynth();
            var queue = new Queue<Point>();
            queue.Enqueue(new Point { X = 0, Y = 0 });
            while (queue.Count != 0)
            {
                var point = queue.Dequeue();
                if (!CanMove(point.X, point.Y)) continue;
                map[point.X, point.Y] = Space.Visited;
                Visualize();
                queue.Enqueue(new Point { X = point.X-1, Y = point.Y });
                queue.Enqueue(new Point { X = point.X+1, Y = point.Y });
                queue.Enqueue(new Point { X = point.X, Y = point.Y-1 });
                queue.Enqueue(new Point { X = point.X, Y = point.Y+1 });

            }
        }
    }
}
