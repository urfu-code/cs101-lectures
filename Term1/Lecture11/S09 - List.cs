using System;
using System.Collections.Generic;

namespace Slide09
{
    public class Program
    {
        public static void MainX()
        {
            var list = new List<int>();//List<int> - это массив интов, а не чего угодно. Мы прямо указываем компилятору, что собираемся хранить
            list.Add(10);
            //list.Add("abc");//Ошибка компиляции: строка - это не число, нельзя положить ее в список чисел.
            list.Add(20);
            var sum=0;
            foreach (var e in list) sum += e; //можно писать var, потому что мы уже сказали компилятору, что храним в списке числа
            
            /* Никогда не используйте ArrayList, пользуйтесь List<int>, List<string>, List<double> и т.д.
             * Сообщайте компилятору, что вы храните в списках.
             * 
             * Такие классы - с угловыми скобками - называются генериками
             */

        }
    }
}