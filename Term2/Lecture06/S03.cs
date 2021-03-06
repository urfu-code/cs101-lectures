﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03
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

        public static bool operator==(Point p1, Point p2)
        {
            if ((object)p1 == null) return (object)p2 == null;
            return p1.Equals(p2);
        }

        public static bool operator!=(Point p1, Point p2)
        {
            return !(p1==p2);
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }


        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.Y + 1);
        }
    }

    class Program
    {
        public static void MainX()
        {
            var point = new Point(0, 0);
            var point1 = new Point(0, 0);
            Console.WriteLine(point == point1);
            Console.WriteLine(point != point1);
            Console.WriteLine(point == null);
            Console.WriteLine(null == point);
        }
    }
}