using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03
{
    class S04
    {
        public static void MaiSn()
        {
            Action<int> f1 = z => Console.WriteLine(z);

            Action<int> f2 = null;
            f2 += z =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(z);
            };
            f2 += z =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(z);
            };
            f2(5);
        }
    }
}
