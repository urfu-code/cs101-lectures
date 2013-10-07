using System;

namespace Slide02
{
    public class Program
    {
        public static void MainX()
        {
            var sum=0;
            string line = Console.ReadLine();   // неудобное определение переменной + дублирование кода!
            while (line != "")
            {
                sum += int.Parse(line);
                line = Console.ReadLine();
            }
        }
    }
}