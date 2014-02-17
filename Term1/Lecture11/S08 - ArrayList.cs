using System;
using System.Collections;

namespace Slide08
{
    public class Program
    {
        public static void MainX()
        {
            var list = new ArrayList(); // ArrayList - это массив всего чего угодно
            list.Add(10);
            list.Add("abc");//Так можно. Нигде не сказано, что в этот массив нельзя складывать строки!
            list.Add(20);
            var sum=0;
            foreach (int e in list) sum += e; 
            //Этот код вызовет ошибку рантайма, потому что строку нельзя сконвертировать в Int

        }
    }
}