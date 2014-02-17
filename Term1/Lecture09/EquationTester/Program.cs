using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EquationTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = QuadricEquation.Solve(1, -2, -3);
            if (result[1] == -1 && result[0] == 3)
                Console.WriteLine("PASS");
            else
                Console.WriteLine("FAIL");
        }
    }
}
