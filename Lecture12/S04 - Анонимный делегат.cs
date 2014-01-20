using System.Collections.Generic;
using System;
namespace L1S04
{
    public class Program
    {
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

        public static void MainX()
        {
            var list = new List<string> { "AAA", "ABC", "AA", "B" };

            //Здесь мы объявляем метод по месту использования
            //Компилятор сам создаст метод anonimous_method_1 с соответствующим телом
            SortAndPrint(list,
                delegate(string s1, string s2)
                {
                    return s1.Length.CompareTo(s2.Length);
                });
            
            SortAndPrint(list,
                delegate(string s1, string s2)
                {
                    return s1.CompareTo(s2);
                });
        }
    }
}
//!Анонимный делегат: прописываем функцию по месту использования
	
	
	
