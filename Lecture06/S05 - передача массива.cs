using System;

namespace Slide05
{
    public class Program
    {
        public static void Method(int[] array)
        {
            array[0] = 5;
        }

        public static void MainX()
        {
            int[] array = new int[5];
            Method(array);
            Console.WriteLine(array[0]);

            /* Программа выведет 5.
             * Method:array и Main:array - по прежнему разные переменные.
             * Но это ссылки. И значение Main:array скопировано в Method:array, поэтому обе ссылки указывают на один и тот же массив.
             * Поскольку это один и тот же массив, его изменение в Method видно в Main
             */
        }
    }
}