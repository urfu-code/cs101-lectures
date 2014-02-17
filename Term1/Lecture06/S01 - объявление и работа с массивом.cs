using System;

namespace Slide01
{
    public class Program
    {
        public static void Main()
        {
            //Объявление и инициализация массива
            int[] array = new int[5];
            //Обращение к его элементам
            array[0] = 10;
            Console.WriteLine(array[0]);

            //Получение длины массива. Индексация цикла идет от 0 до Length-1
            for (int i = 0; i < array.Length; i++)
                array[i] = i;



        }
    }
}