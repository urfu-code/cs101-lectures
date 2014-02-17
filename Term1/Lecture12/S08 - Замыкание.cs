using System.Collections.Generic;
using System;
namespace L1S08
{
    public class Program
    {
       
        public static void Main()
        {
            //Иногда при замыкании происходят неожиданные эффекты =)

            var list = new Action<int>[5];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = x => Console.WriteLine(x + i);
                //Раскомментируйте две следующие строчки, чтобы все заработало правильно
                //var j = i;
                //list[i] = x => Console.WriteLine(x + j);
            }

            for (int i = 0; i < list.Length; i++)
                list[i](0);

        }
    }
}

	
	
