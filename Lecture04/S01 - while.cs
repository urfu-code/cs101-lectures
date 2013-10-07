using System;

namespace Slide01
{
    public class Program
    {
        public static void MainX()
        {
            int number = 1;
            while (number < 100)            // пока выполняется условия
            {
                number *= 2;                // делай инструкции в теле цикла
                Console.WriteLine(number);
            }
        }
    }
}