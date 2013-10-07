using System;

namespace Slide02
{
    public class Program
    {
        public static void MainX()
        {
            //Здесь объявляется ссылка на массив. Ссылка лежит в контексте метода в стэке. Сейчас она не ведет никуда.
            int[] array = null;

            // array[0]=5; // Null reference exception: нельзя обратиться к нулевому элементу массива, т.к. он еще не создан.

            array = new int[5]; //Здесь в куче выделяется память для массива, и в array кладется адрес этой памяти.

            Console.WriteLine(array[0]); //Выведет 0, т.к. массив заполнен значениями по умолчанию.

        }
    }
}