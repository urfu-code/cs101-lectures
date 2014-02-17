using System;
using System.Collections.Generic;

namespace Slide10
{
    public class Program
    {
        public static void MainX()
        {
            // Существуют и другие генерики, например, Dictionary
            var dictionary = new Dictionary<string, int>();
            var list = new List<string> { "A", "A", "B", "AB" };

            //Словарь позволяет установить соответствие между ключом (строкой) и значением (количеством вхождений в массив)
            foreach (var e in list)
                if (!dictionary.ContainsKey(e)) dictionary[e] = 1;
                else dictionary[e]++;

            //словарь - это массив пар "Ключ-значение"
            foreach (var pair in dictionary)
                Console.WriteLine("{0,10}{1,10}", pair.Key, pair.Value);

        }
    }
}