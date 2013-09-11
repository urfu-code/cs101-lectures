using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    class Program
    {
        static void MainX()
        {
            int firstNumber = 12;
            int secondNumber = 45;

            int sum = firstNumber + secondNumber;

            // Но ведь и так понятно, что сумма целых чисел - целое число, не так ли?

            var secondSum = firstNumber + secondNumber; // Поэтому можно использовать ключевое слово var 

            /* var - ЭТО НЕ ТИП! secondSum имеет тип int. 
             * var - это ключевое слово, которое позволяет не указывать "и так понятный тип"
             */

        }
    }
}
