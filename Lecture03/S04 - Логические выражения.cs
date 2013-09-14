using System;

namespace Slide04
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine((5 < 4) && (3 < 4));
            Console.WriteLine((5 < 4) || (3 < 4));
            Console.WriteLine(!(5 < 4));
        }
    }
}