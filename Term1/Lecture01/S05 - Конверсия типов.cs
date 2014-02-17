using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{
    class Program
    {
        static void MainX()
        {
            int integerNumber = 45;
            double doubleNumber = 34.56;

            doubleNumber = integerNumber; /* Это неявная конверсия типов: присвоение переменной одного типа 
                                           * значения переменной другого типа без дополнительных усилий. 
                                           * Она возможна, когда не происходит потери информации */

            integerNumber = (int)doubleNumber; /* Это явная конверсия типов. В случае, когда конверсия ведет к потере информации
                                                * (в данном случае - дробной части), необходимо явно обозначать свои намерения
                                                * по конверсии.
                                                */

            integerNumber = (int)Math.Round(34.67); /* Округление лучше всего делать не конверсией, а функцией Round. 
                                                     * Кстати, Math - "математическая библиотека" C# - имеет множество других
                                                     * полезных методов. 
                                                     */

            long longInteger = 4000000000;
            integerNumber = (int)longInteger; /* При такой конверсии происходит ошибка переполнения, которая, однако, остается
                                               * незамеченной для компилятора и среды разработки */

            checked
            {
                integerNumber = (int)longInteger; // Таким образом можно отловить эти ошибки явно 
            }
        }
    }
}
