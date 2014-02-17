using System;

namespace Slide06
{
    public class Point
    {
        public double X;
        public double Y;
    }


    public class Polygon
    {
        public Point[] Points;

        //Можно сделать дополнительные действия по инициализации класса в конструкторе
        public Polygon(int verticesCount)
        {
            Points = new Point[verticesCount];
            for (int i = 0; i < Points.Length; i++)
                Points[i] = new Point();
        }
    }



    public class Program
    {
        public static void MainX()
        {
            var poly = new Polygon(4);
           
            //Это делать больше не нужно, потому что это сделано в конструкторе
            //poly.Points = new Point[4];
            //poly.Points[0] = new Point();
            
            poly.Points[0].X = 0;
            poly.Points[0].Y = 0;
            
              




        }
    }
}