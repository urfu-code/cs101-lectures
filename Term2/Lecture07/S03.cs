using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S03
{
    struct MyStruct
    {
        public int X;
        public int Y;
        public MyStruct(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        public static void MainX()
        {
            MyStruct a = new MyStruct();
            a.X = 1;
            a.Y = 2;

            a = new MyStruct(4, 5);


        }


    }
}
