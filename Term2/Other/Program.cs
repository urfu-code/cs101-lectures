using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other1
{
    static class BoolArrayExtensions
    {
        static public void Negate(this bool[,] array, int x, int y)
        {
            array[x, y] = !array[x, y];
        }
    }

    class Program
    {
        static void MainX(string[] args)
        {
            bool[,] field = new bool[4, 4];
            int x=2; int y=3;

            field.Negate(x, y);
            BoolArrayExtensions.Negate(field, x, y);
        }
    }
}
