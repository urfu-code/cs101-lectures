using System;
using System.Collections.Generic;
namespace Lecture13
{
    public static class L1S10
    {
        public static IEnumerable<T> Where<T>(
            this IEnumerable<T> array,
            Func<T, bool> predicate)
        {
            foreach (var e in array)
                if (predicate(e))
                    yield return e;
        }

        public static IEnumerable<TOut> Select<TIn, TOut>(
            this IEnumerable<TIn> array,
            Func<TIn, TOut> selector)
        {
            foreach (var e in array)
                yield return selector(e);
        }


        public static void Main()
        {
            var array = new string[] { "A", "B", "CD", "EF" };
            foreach (var e in 
                array
                    .Where(z => z[0]!='B')
                    .Select(z=>z.Length))
            
            {
                Console.WriteLine(e);
            }

        }

    }
}
