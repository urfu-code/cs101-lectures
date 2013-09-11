using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide06
{
    class Program
    {
        static void MainX()
        {

            int integerNumber = 12;

            // string text = integerNumber; // Так делать нельзя
            // string text = (string)integerNumber; // Так тоже нельзя. Это не конверсия, а нетривиальная операция, наподобие Math.Round


            string text = integerNumber.ToString(); /* Все что угодно можно превратить в строку с помощью ToString().
                                                     * Но результат не обязательно вам понравится 
                                                     */

            integerNumber = int.Parse("234"); // Перевод строки в числа осуществляется с помощью метода Parse

            var realNumber = double.Parse("34.56"); // Этот метод зависит от текущей культуры операционной системы. 

            realNumber = double.Parse("34.56", CultureInfo.InvariantCulture); //Вот так этого можно избежать

        }
    }
}
