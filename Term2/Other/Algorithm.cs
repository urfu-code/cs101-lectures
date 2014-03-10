using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{

    class Program
    {
        static IEnumerable<int> ConsoleEnum
        {
            get
            {
                while (true)
                {
                    var str = Console.ReadLine();
                    if (str == "") yield break;
                    else yield return int.Parse(str);
                }
            }
        }

        public static bool FilterNotZero(int z)
        {
            return z != 0;
        }

        public static void Main()
        {
            
            //Algorithm.IsProof1(10,
            //   ()=>int.Parse(Console.ReadLine())
            //    );

            //Algorithm.IsProof2(10, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Algorithm.IsProof2(5, ConsoleEnum);
        }
    }
    class Algorithm
    {
        public static bool IsProof2(int n, IEnumerable<int> source)
        {
            int i = 0;
            foreach (var e in source)
            {
                if (i > n) break;
                //do something
            }
            return true;
        }

        public static bool IsProof1(int n, Func<int> nextElement)
        {
            for (int i = 0; i < n; i++)
            {
                var e = nextElement();
            }
            return true;
        }

        public static bool IsProof(int[] array)
        {
            throw new NotImplementedException();
        }

      
    }
}
