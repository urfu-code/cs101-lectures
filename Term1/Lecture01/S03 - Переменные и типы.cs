using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide03
{
    class Program
    {
        static void MainX()
        {
           /*
            * Переменная - это именованная область памяти.
            * 
            * Тип переменной - это формат области памяти, определяющий множество возможных значений переменной,     
            *                  и множество допустимых операций над ней
            */
            
            int integerNumber; // так объявляется переменная: тип (int), затем имя (integerNumber)
            integerNumber = 10; // так осуществляется присваивание

            Console.WriteLine(int.MaxValue); // можно узнать некоторые полезные вещи о типе с помощью его методов

            double realNumber = 12.34; // double - основной тип чисел с плавающей точкой

            string text = "Hello, world"; // string - третий из четырех основных типов. Четвертый мы рассмотрим несколько позже

            long longIntegerNumber = 3000000000000; /* есть и другие типы, например, long (большие целые числа). 
                                                     * Но, в основном, вы будете пользоваться int, double и string */
           
        }
    }
}
