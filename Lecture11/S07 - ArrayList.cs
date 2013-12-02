using System;
using System.Collections;

namespace Slide07
{
    public class Program
    {
        public static void MainX()
        {
            var list = new ArrayList(); // ArrayList - это массив всего чего угодно
            list.Add(10);
            list.Add(20);
            var sum=0;
            //foreach (var e in list) sum += e; //ошибка! Мы нигде не сказали компилятору, что в массиве лежат числа. 
                                                //ArrayList - это массив чего угодно, а что угодно складывать нельзя!
            foreach (int e in list) sum += e; //здесь мы явно указываем компилятору, что предполагаем, будто в list лежат числа


        }
    }
}