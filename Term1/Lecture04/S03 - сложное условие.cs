using System;

namespace Slide03
{
    public class Program
    {
        public static void MainX()
        {
            var sum=0;
            string line=null;
            while ((line=Console.ReadLine())!="") // присвоение и сравнение в одном условие. Это работает, но так лучше не писать
                sum += int.Parse(line);             
        }
    }
}