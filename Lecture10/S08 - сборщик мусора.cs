using System;

namespace Slide08
{
    public class Program
    {
        static void SomeMethod()
        {
            //Это локальная переменная. После выхода из этого метода ссылка на нее будет утрачена,
            //и за ней приедет сборщик мусора
            var variable = new byte[1000000];
        }

        public static void Main()
        {
            for (int i = 0; i < 20; i++)
            {
                SomeMethod();
                /* Можно заставить сборщик приехать в нужный момент. 
                 * Обратите, кстати, внимание, что сборщик мусора - статический! Он один!
                 */
                //GC.Collect(); 

                /* Без специального приглашения, сборщик мусора приезжает, когда ему вздумается.
                 * Поэтому программы на шарпе - не RealTime.
                 */
                Console.WriteLine(GC.GetTotalMemory(false));
            }

            Console.ReadKey();

        }
    }
}