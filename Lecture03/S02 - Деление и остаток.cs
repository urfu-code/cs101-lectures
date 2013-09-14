using System;

namespace Slide02
{
    public class Program
    {
        public static void MainX()
        {
            int integerDividend = 100;
            int integerDivisor = 3;

            //Операция целочисленного деления
            Console.WriteLine(integerDividend / integerDivisor);
            //Операция взятия остатка
            Console.WriteLine(integerDividend % integerDivisor);

            //Что делать, если нужно нецелочисленное деление?
            Console.WriteLine((double)integerDividend / integerDivisor);
            Console.WriteLine(integerDividend / (double)integerDivisor);
            double doubleDividend = integerDividend;
            Console.WriteLine(doubleDividend / integerDivisor);
            
            


        }
    }
}