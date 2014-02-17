using System;

namespace Slide08
{
    public class Program
    {
        public static void MainX()
        {
            for (;;) //Ктулху-фор - вечный цикл
            {
                break;
            }


            //Да, так тоже можно
            int sum=0;
            for (
                    var line = Console.ReadLine();
                    line != "";
                    sum+=int.Parse(line), line=Console.ReadLine()
                    ) ;
                        
            //На самом деле, for(int i=0;i<5;i++) - синтаксический сахар примерно для вот этого:
            int i = 0;
            while (i < 5)
            {
                // инструкции цикла
                i++;
            }

            /*
             * for и while теоретически взаимозаменяемы.
             * Поэтому:
             *  ИСПОЛЬЗУЙТЕ FOR, если есть четко выделяемая переменная цикла, которая изменяется с каждой итерацией
             *  ИСПОЛЬЗУЙТЕ WHILE во всех остальных случаях
             */


        }
    }
}