using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class QuadricEquation
    {
        public static double[] Solve
            (double A, double B, double C)
        {
            if (A == 0)
                return new double[] { -C / B };

            var squareOfDisc = Math.Sqrt(B * B - 4 * A * C);
            if (double.IsNaN(squareOfDisc)) 
                return new double[0];
            if (squareOfDisc == 0)
                return new double[] { -B / (2 * A) };
            return new[] 
            {
                (- B + squareOfDisc)/(2*A),
                (- B - squareOfDisc)/(2*A)
            };
        }
    }
}
