using System;

namespace Slide05
{
    public class Program
    {
        public static void MainX()
        {
            int sum = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "") break;
                if (line.Length > 100) continue; //запросить следующую линию
                sum += int.Parse(line);
            }
        }
    }
}