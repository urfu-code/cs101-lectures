using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05
{
    public class A
    {
        public static A operator +(A a, string s)
        {
            throw new NotImplementedException();
        }

        public static A operator +(A a, A b)
        {
            throw new NotImplementedException();
        }

    }

    class Program
    {
        public static void MainX()
        {
            var a = new A();
//            Console.WriteLine(a + null);
            A b = null;
            Console.WriteLine(a + b);
            
        }
    }

}