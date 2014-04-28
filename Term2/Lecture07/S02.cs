using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S02
{
    struct MyStruct
    {
        public int X;
        public int[] Array;
    }

    class Program
    {
        public static void MainX()
        {
            var p = new MyStruct { X = 1, Array=new int[3]};
            ProcessStruct(p);
            Console.WriteLine(p.Array[0]);
        }

        static void ProcessStruct(MyStruct p)
        {
            p.Array[0] = 100;
        }

    }
}
