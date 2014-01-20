using System;
using System.Collections.Generic; //это пространство имен содержит определения Where, Select и других LINQ-методов
using System.Linq;

namespace Slide03
{
    public static class Program
    {

        //Иногда чего-то не хватает, и это приходится дописывать руками, вот так:
        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (var e in list)
                action(e);
        }


        public static void MainX()
        {
            Enumerable
                .Range(0, 100) //это создает перечисление чисел от 0 до 100 (исключая 100)
                .Select(z => z * 10) //это увеличивает в 10 раз
                .Where(z => z % 7 == 0) //это отбирает кратные 7
                .ForEach(z => Console.WriteLine(z)); //Это печатает

        }
    }
}