using System.Collections.Generic;
using System;
namespace L1S03
{
    public class Program
    {
        //Здесь мы используем системный генерик-делегат Func вместо объявления собственного
        //Объявление Func<T1,T2,TOut> означает метод, принимающий T1, T2 в качестве аргументов и возвращающий TOut
        public static void SortAndPrint(
            List<string> array, 
            Func<string,string,int> comparer)
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
            SortAndPrint(list, LengthComparer);
            SortAndPrint(list, AlphabeticComparer);
        }
    }
}
//!Убираем декларацию делегатов: заготовлены генерик-декларации на все случаи жизни
	
	
	
