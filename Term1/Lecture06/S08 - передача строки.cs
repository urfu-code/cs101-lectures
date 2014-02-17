using System;

namespace Slide08
{
    public class Program
    {
        public static void Method(string str)
        {
            str = "a";
        }

        public static void MainX()
        {
            string str = "x";
            Method(str);
            Console.Write(str);

            /* Выведется x
             * "x" и "a" - две разные строки в разных областях памяти.
             * Ссылка Method:str стала указывать на "a", но при этом Main:str по-прежнему указывает на "x"
             */
        }
    }
}