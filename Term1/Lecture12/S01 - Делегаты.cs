﻿using System.Collections.Generic;
using System;
namespace L1S01
{
    //Здесь мы объявляем делегат: тип указателя на методы, имеющих следующую сигнатуру:
    //Они принимают две строки и возвращают число
    public delegate int StringComparer(string arg1, string arg2);

    public class Program
    {
        //В этот метод передается comparer - ссылка на метод, который будет производить сравнение элементов
        public static void SortAndPrint(List<string> array, StringComparer comparer)
        {
            for (int i = 0; i < array.Count; i++)
                for (int j = 0; j < array.Count; j++)
                    if (comparer(array[i], array[j]) < 0)
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            foreach (var e in array)
                Console.Write("{0,5} ", e);
            Console.WriteLine();
        }

        public static int LengthComparer(string s1, string s2)
        {
            return s1.Length.CompareTo(s2.Length);
        }

        public static int AlphabeticComparer(string s1, string s2)
        {
            return s1.CompareTo(s2);
        }

        public static void MainX()
        {
            var list = new List<string> { "AAA", "ABC", "AA", "B" };
            SortAndPrint(list, new StringComparer(LengthComparer));
            SortAndPrint(list, new StringComparer(AlphabeticComparer));
        }
    }
}
