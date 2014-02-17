using System;

namespace Slide09
{
    public class Program
    {
        public static void Method(string str)
        {
            str += "a";
        }

        public static void MainX()
        {
            string str = "x";
            Method(str);
            Console.Write(str);

            /* Выведется по-прежнему x
             * При выполнении str+="a", т.е. str=str+"a", сначала создается НОВАЯ строка "xa", а потом Method:str переводится 
             * на вновь созданную строку.
             * Main:str по-прежнему указывает на "x"
             * Объект string неизменяем. Вообще! Любое изменение строки порождает новую строку!
             */
        }
    }
}