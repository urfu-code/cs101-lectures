using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide07
{
    class Program
    {
        /* В С# нет "процедур" и "функция" - есть только методы.
         * Так объявляется "функция":
         * static (волшебное слово)
         * тип значения, которое возвращает функция (в данном случае, int)
         * имя метода (MyFunction)
         * Далее в круглых скобках - список аргументов в формате "тип-имя" через запятую.
         */
        static int MyFunction(int firstArgument, int secondArgument)
        {
            var resultat = firstArgument + secondArgument; // аргументы метода используются в теле метода как переменные
            return firstArgument+secondArgument; // слово return возвращает значение метода
        }
        
        /* Это - метод, не возвращающий значения.
         * В этом случае вместо типа указывается ключевое слово void
         * В этом случае return пишется без аргумента, и его можно опустить.
         */
        static void MyProcedure(string text)
        {
            Console.WriteLine(text);
            return;
        }


        static void MainX()
        {
            // Так вызываются методы
            Console.WriteLine(MyFunction(45, 67));
            MyProcedure("Hello, world!"); 
        }
    }
}
