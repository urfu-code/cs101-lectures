using System;

namespace Slide07
{
    public class Program
    {
        public static void Method(string str)
        {
            //str[0]='a'; //Так делать нельзя. Строки - неизменяемые!
        }

        public static void MainX()
        {
            string str = "x";
            Method(str);
        }
    }
}