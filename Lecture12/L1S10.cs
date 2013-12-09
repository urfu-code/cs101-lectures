using System;
using System.Collections.Generic;
namespace Lecture12
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


        public static void MainX()
        {
            var array = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            foreach (var e in array.Where(z => z % 2 == 0))
            {
                Console.WriteLine(e);
            }

        }

    }
}
