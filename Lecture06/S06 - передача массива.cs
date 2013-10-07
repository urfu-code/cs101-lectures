using System;

namespace Slide06
{
    public class Program
    {
        public static void Method(int[] array)
        {
            array = new int[5];
            array[0] = 5;
        }

        public static void MainX()
        {
            int[] array = new int[5];
            Method(array);
            Console.WriteLine(array[0]);

            /* Программа выведет 0.
             * После вызова Method, ссылка Method:array указывает на тот же массив, что и Main:array
             * Но в первой строке метода Method, Method:array переводится на другой массив.
             * Теперь массива два, и ссылки указывают на разные массивы.
             * Поэтому изменение одного массива в методе Method никак не изменяет второй массив, на который указывает Main:array.
             */
        }
    }
}