using System;
using System.Collections.Generic;

namespace Slide11
{
    public class Program
    {
        //Tuple - еще один полезный генерик
        //Он позволяет, например, быстро вернуть из метода два значения, в нашем случае - два числа
        //Альтернатива - это создать класс специально для этого метода, но это неудобно
        public static Tuple<int, int> MakeDivision(int a, int b)
        {
            return Tuple.Create(a / b, a % b);
        }

        public static void MainX()
        {
            var res = MakeDivision(5, 2);
            Console.WriteLine("{0,10}{1,10}",res.Item1, res.Item2);
        }
    }
}