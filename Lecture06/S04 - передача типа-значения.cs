using System;

namespace Slide04
{
    public class Program
    {
        public static void Method(int variable)
        {
            variable = 5;
        }

        public static void MainX()
        {
            int variable = 0;
            Method(variable);
            Console.WriteLine(variable);

            /* Программа выведет 0.
             * Поскольку int - тип-значение, это значение хранится в контексте метода, в стэке.
             * Main:variable и Method:variable - это разные области памяти. 
             * При вызове Method значение Main:variable копируется в Method:variable. 
             * Обратного копирования не происходит!
             */
        }
    }
}