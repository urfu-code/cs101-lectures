using System;
using System.Collections.Generic;
using System.Linq;

namespace Slide05
{
    public static class Program
    {

        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var e in collection)
                Console.WriteLine(e);
        }

        public static void MainX()
        {
            //Я хочу сделать множество [0,5] X [0.5]

            Enumerable
                .Range(0, 6) //до 6, потому что 5 должно входить
                .Select(z =>
                    Enumerable
                        .Range(0, 6)
                        .Select(x => string.Format("({0},{1})", z, x)) //тут я использую z с помощью замыкания
                        );
            //Так получается коллекция коллекций, а мне бы хотелось коллекцию. Как быть?

            Enumerable
              .Range(0, 6)
              .SelectMany(z =>  //SelectMany делает из коллекции коллекций обычную одномерную коллекцию
                  Enumerable
                      .Range(0, 6)
                      .Select(x => string.Format("({0},{1})", z, x)) //тут я использую z с помощью замыкания
                      )
              .Print();
       

        }
    }
}