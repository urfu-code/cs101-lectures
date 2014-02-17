using System;

namespace Slide01
{
    public class Program
    {
        public static void MainX()
        {
            //Операция присваивания
            int variable = 10;

            //Неочевидно, что операция присваивания сама по себе имеет значение. Поэтому можно писать так:
            Console.WriteLine(variable = 10);
            
            //Приращение числа на единицу
            variable = variable + 1;
            
            //можно сокращенно написать так
            variable += 1;

            //Аналогично со всеми другими бинарными операциями
            variable = variable * 2;
            variable *= 2;

            //Для случая variable = variable + 1 есть две более короткие записи:
            variable++;
            ++variable;

            //Они отличаются возвращаемым значением
            variable = 10;
            Console.WriteLine("Variable++:  " + (variable++).ToString());
            Console.WriteLine("Value after: " + variable.ToString());

            variable = 10;
            Console.WriteLine("++Variable:  " + (++variable).ToString());
            Console.WriteLine("Value after: " + variable.ToString());

            



        }
    }
}