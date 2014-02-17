using System;
using System.Collections.Generic;

namespace Slide16
{
   

    public class Program
    {
        public static IEnumerable<double> Range(double min, double max, double delta)
        {
            for (double i = min; i <= max; i += delta)
                yield return i;
            //var list = new List<double>();
            //for (double i = min; i <= max; i += delta)
            //    list.Add(i);
            //return list;
        }

        public static void Main()
        {
            foreach (var e in Range(0, 1, 0.1))
            {
                Console.WriteLine(e);
            }
        }
    }
}