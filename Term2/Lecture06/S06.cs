using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S06
{
    public class Angle
    {
        double value;

        public static explicit operator double(Angle a)
        {
            return a.value;
        }

        public static implicit operator Angle(double value)
        {
            return new Angle { value = value };
        }

    }

    public class Program
    {
        public static void Main()
        {
            Angle var = 5;
            double d = (double)var;
        }
    }
}