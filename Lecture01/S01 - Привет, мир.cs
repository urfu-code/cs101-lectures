﻿using System; // Подключение пространства имен, в котором содержится Console

namespace Slide01 // Объявление собственного пространства имен
{
    class Program // Объявление класса (магия, к которой мы вернемся в следующих лекциях)
    {
        static void Main() // Объявление точки входа - метода, который вызывается в момент старта программы
        {
            Console.WriteLine("Hello, world!"); //Вывод на дисплей
            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }
}
