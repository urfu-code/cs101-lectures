using System;

namespace Slide10
{
    public class Program
    {
        public static void MainX()
        {
            int[][] array = new int[5][];
            
            Console.WriteLine(array.Length); //В этом массиве - 5 массивов

            // Console.WriteLine(array[0].Length); //Null reference exception! Массив - это ссылочный тип, поэтому array наполнен null!

            array[0] = new int[2]; //Теперь первый элемент массива массивов указывает на массив из двух чисел

            Console.Write(array[0].Length); //И это можно увидеть на консоли
        }
    }
}