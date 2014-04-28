using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04
{
    class Angle
    {
        double value;
        public static Angle operator+(Angle a, Angle b)
        {
            return new Angle { value=a.value+b.value };
        }

        public static Angle operator*(Angle a, double c)
        {
            return new Angle { value=a.value*c };
        }

        public static Angle operator *(double c, Angle a)
        {
            return new Angle { value = a.value * c };
        }

        public static double operator /(Angle a, Angle b)
        {
            return a.value / b.value;
        }


    }

}