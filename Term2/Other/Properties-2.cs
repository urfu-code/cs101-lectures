using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other02
{
    class Point
    {
        public int X;
        public int Y;
    }

    class Point1
    {
        private int x;
        public int X { get { return x; } set { x = value; } }

        public int Y { get; set; }
    }
}