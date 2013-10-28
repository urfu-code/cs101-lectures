using System;

namespace Slide02
{
    public class Program
    {
        public static void MainX()
        {
            //Символ перевода строки
            Console.WriteLine("First line\nSecond line"); 

            //Символ возврата каретки
            Console.WriteLine("10%\r20%\r30%");

            //Символ табуляции - плохой способ делать таблички
            Console.WriteLine("10\t100\n10000\t1");

            //Вывод кавычки
            Console.WriteLine("This is \" quotes");

            //Так писать нельзя, поскольку компилятор пытается воспринять \U как спецсимвол
            //Console.WriteLine("C:\Users\admin"); // ошибка компиляции

            //Поэтому бэкслэш надо экранировать
            Console.WriteLine("C:\\Users\\admin");

            //Или использовать особую строку, в которой спецсимволы не допускаются
            Console.WriteLine(@"C:\Users\admin");

            //Такую строку удобно использовать для того, чтобы набивать в шарпе длинные строки, фрагменты документов или кода
            Console.WriteLine(
@"
\section{Section 1}
Some {\i LaTeX} text here.");

            //Единственный символ, который нужно экранировать внутри особой строки - кавычки. Они экранируются удвоением
            Console.WriteLine(@"This is "" quotes");


        
        }
    }
}