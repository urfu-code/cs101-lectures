using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide08
{
    class Program
    {
        static string globalVariable = "Global variable";

        static void MethodA()
        {
            string localVariable = "Local variable";
            Console.WriteLine(localVariable); // Так можно: эта переменная используется в той же области, где и объявлена
        }

        static void MethodB()
        {
            // Console.WriteLine(localVariable); // Так нельзя: переменная определена в другом методе.
            Console.WriteLine(globalVariable); //Так можно: это глобальная переменная

            /* Переменная доступно (грубо) внутри тех фигурных скобок, где она определена.
             * Области кода, из которого допустимо обращение к переменной, называется "областью видимости"
             */
        }
    }
}
