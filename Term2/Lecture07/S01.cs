using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S01
{
    struct Point
    {
        public int X;
        public int Y;
    }

    class Program
    {
        public static void MainX()
        {
            var p = new Point { X = 1, Y = 1 };
            ProcessPoint(p);
            Console.WriteLine(p.X);
        }

        static void ProcessPoint(Point p)
        {
            p.X = 2;
        }

    }
}
