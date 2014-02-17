using System;
using System.IO;
using System.Text;

namespace Slide06
{
    public class Program
    {
        
        public static void MainX()
        {
            //Класс Directory - простейший способ получить доступ к структуре каталогов
            //Исследуйте его методы самостоятельно с помощью Intellisense
            foreach (var e in Directory.GetFiles("."))
            {
                Console.WriteLine(e);
            }
            

        }
    }
}