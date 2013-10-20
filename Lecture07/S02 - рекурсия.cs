using System;

namespace Slide02
{
    public class Program
    {
        static void Make(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i.ToString() + " ");
                Make(i);
            }
        }

        public static void MainX()
        {
            Console.Write("Make(1): ");
            Make(1);
            Console.WriteLine();

            Console.Write("Make(2): ");
            Make(2);
            Console.WriteLine();

            Console.Write("Make(3): ");
            Make(3);
            Console.WriteLine();

        }
    }
}