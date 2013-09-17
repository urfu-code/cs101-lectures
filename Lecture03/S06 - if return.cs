using System;

namespace Slide06
{
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    public class Program
    {
        static string ColorName(Colors color)
        {
            if (color == Colors.Red) return "Красный";
            else if (color == Colors.Blue) return "Синий";
            else return "Зеленый";
        }

        static string ColorNameWrongWay(Colors color)
        {
            if (color == Colors.Red) return "Красный";
            if (color == Colors.Blue) return "Синий";
            if (color== Colors.Green) return "Зеленый";

            return ""; 
                        /* компилятор не знает, что это взаимоисключающие возможности! Если закомментировать предыдущую строку,
                        * то будет ошибка "not all code paths return a value" - т.е. существуют некоторые ветви алгоритма,
                         которые не возвращают значения. Но метод должен вернуть значение в любом случае, поэтому это - ошибка. */
        }
    }
}