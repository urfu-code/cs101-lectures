using System;

namespace Slide04
{
    public class Program
    {
        public static void MainX()
        {
            //Оптимальный вариант, все читаемо и логика цикла понятно
            int sum = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "") break; //break прерывает выполнение инструкций цикла и выходит из него
                sum += int.Parse(line);
            }
        }
    }
}