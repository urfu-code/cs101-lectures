using System.Collections.Generic;
using System;
namespace L1S06
{
    public class Program
    {
        //Здесь мы сделали генерик-метод, который будет сортировать массив всего чего угодно
        public static void SortAndPrint<T>
            (List<T> array, 
            Func<T,T,int> comparer)
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

        public static void MainX()
        {
            var list = new List<string> { "AAA", "ABC", "AA", "B" };
            //Обратите внимание, что тип s1 зависит от того, какая коллекция передана в метод SortAndPrint
            SortAndPrint(list, (s1, s2) => s1.Length.CompareTo(s2.Length));

            var list1 = new List<int> { 1, 4, 2, 3 };
            SortAndPrint(list1, (s1, s2) => s1.CompareTo(s2));
        }
    }
}
	
