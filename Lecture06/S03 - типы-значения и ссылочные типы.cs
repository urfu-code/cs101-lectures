using System;

namespace Slide03
{
    public class Program
    {
        public static void MainX()
        {
            //Теперь объявим массив строк
            string[] array = new string[5];
  
            //Null Reference Exception!
            Console.WriteLine(array[0].Length);

            /* Почему так? Бывают разные типы: 
             * типы-значения: int, bool, double. Они занимают фиксированный объем памяти, и находятся в самом массиве.
             * ссылочные типы: string, int[]. Неизвестно, какой объем памяти займет строка, 
             *                 и поэтому она не создается в момент создания массива.
             *                 Она лежит отдельно, а в массиве - лишь ссылка на нее.
             *                 Пока в array[0] не лежит никакой строки, а значит, и длину считать нельзя.
             */
        }
    }
}