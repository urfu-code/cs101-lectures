using System;
using System.Collections.Generic;
using System.Linq;

namespace Slide06
{
    public static class Program
    {

        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var e in collection)
                Console.WriteLine(e);
        }

        public static void Main()
        {
            //GroupBy позволяет получить из коллекции -> коллекцию коллекций, которые объединены неким признаком

            Enumerable
                .Range(0, 10)
                .GroupBy(z => z % 5) //группируем числа по остатку от деления на пять
                .Select(z => string.Format("{0} : {1}", //и каждую такую коллекцию мы превращаем в строку...
                    z.Key, //где сначала идет признак группировки, т.е. отстаток от деления на 5
                    z.Sum())) //а здесь я считаю сумму чисел в каждой из таких коллекций
                .Print();

            //Усложним задачу
            Enumerable
               .Range(0, 10)
               .GroupBy(z => z % 5) 
               .Select(z => string.Format("{0} : {1}", 
                   z.Key, 
                   z
                        .Select(x=>x.ToString())   //здесь я превращаю список чисел в список строк
                        .Aggregate((result,element)=>result+","+element) //а здесь я агрегирую его. Этот метод принимает накопленный результат, и присоединяет к нему текущий элемент
                        ))
               .Print();

       

        }
    }
}