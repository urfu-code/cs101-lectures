using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    class Statistics
    {
        public int Success;
        public int Total;
        public double GetPercent() { return 100 * (double)Success / Total; }
    }

    class Properties
    {
        public static void Main()
        {
            var stat = new Statistics();
            stat.Success = 146;
            stat.Total = 100;
        }
    }
}