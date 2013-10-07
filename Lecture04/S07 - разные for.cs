using System;

namespace Slide07
{
    public class Program
    {

        static int GetBound()
        {
            Console.Write("!");
            return 5;
        }

        public static void MainX()
        {
            //Декремент
            for (int i = 9; i >=0; i--)
                Console.Write(i + " ");

            Console.WriteLine();
            //Допускается произвольное изменение переменной
            for (int i = 1; i < 100; i *= 2)
                Console.Write(i + " ");

            Console.WriteLine();
            //Не обязательно инициализировать переменную
            int start = int.Parse(Console.ReadLine());
            for (; start >= 0; start--)
                Console.Write(start + " ");

            Console.WriteLine();
            //И условие тоже может быть произвольным
            for (; start * start < 5 * start; start++)
                Console.Write(start + " ");

            Console.WriteLine();
            
            //Проверка условия осуществляется КАЖДУЮ итерацию цикла! 
            //Поэтому в данном случае лучше ввести переменную var bound=GetBound() и сравнивать с ней,
            //а не вызывать цикл каждый раз
            for (int i = 0; i < GetBound(); i++)
                Console.Write(i + " ");
        
        }


    }
}