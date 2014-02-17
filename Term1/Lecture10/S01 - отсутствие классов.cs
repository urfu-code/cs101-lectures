using System;

namespace Slide01
{
    public class Program
    {

        /*
         * Так мы писали до сих пор.
         * Это не очень хорошо, поскольку 
         * 1) Никак не гарантируется, что массивы одинаковой длины
         * 2) Только из названий можно понять, что обозначают эти массивы
         */
        static double GetPerimeter(double[] x, double[] y)
        {
            double length = 0;
            for (int i = 0; i < x.Length; i++)
                length += Math.Sqrt(
                    Math.Pow(x[i] - x[(i + 1) % x.Length], 2) +
                    Math.Pow(y[i] - y[(i + 1) % y.Length], 2));
            return length;
        }

        static void MainX()
        {
            Console.WriteLine(GetPerimeter(
                new double[] { 0, 0, 1, 1 },
                new double[] { 0, 1, 1, 0 }));
        }
    }
}
