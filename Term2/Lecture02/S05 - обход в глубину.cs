using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class S05
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
            Go(0, 0);
        }
    }
}
