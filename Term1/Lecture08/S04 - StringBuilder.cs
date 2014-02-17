using System;
using System.Text;

namespace Slide04
{
    public class Program
    {
        public static void MainX()
        {
            //Это очень долго!
            //Каждую итерацию цикла создается новая строка размера ~i
            //В результате алгоритм потребляет ~N^2 памяти, а значит, и его сложность ~N^2
            //Сложение строк нельзя рассматривать как элементарную операцию
            var result = "";
            var N = 10000;
            for (int i = 0; i < N; i++)
                result += i.ToString() + ",";

            //StringBuilder - это изменяемая строка
            //Можно добавлять в конец, вставлять в середину, менять отдельные символы
            //Нижеследующий код работает в разы быстрее
            var builder = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                builder.Append(i);
                builder.Append(",");
            }
            result = builder.ToString();




        }
    }
}