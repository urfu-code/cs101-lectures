using System.Collections.Generic;
using System;
namespace L1S02
{
    public delegate int StringComparer(string arg1, string arg2);

    public class Program
    {
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
          
            StringComparer c = LengthComparer;
            var list = new List<string> { "AAA", "ABC", "AA", "B" };
            SortAndPrint(list, LengthComparer);
            SortAndPrint(list, AlphabeticComparer);
        }
    }
}
	
//!Не нужно создавать делегат явно: компилятор сам все поймет
	
	
