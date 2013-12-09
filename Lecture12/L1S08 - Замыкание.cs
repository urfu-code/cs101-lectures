using System.Collections.Generic;
using System;
namespace L1S08
{
    public class Program
    {
       
        public static void MainX()
        {
            var list = new Action<int>[5];
            for (int i = 0; i < list.Length; i++)
            {
                var j = i;
                list[i] = x => Console.WriteLine(x + j);
            }

            for (int i = 0; i < list.Length; i++)
                list[i](0);

        }
    }
}

	
	
