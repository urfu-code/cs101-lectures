using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other02
{
    class Statistics
    {
        private int success;
        int total;
        public double GetPercent() { return 100 * (double)success / total; }

        public int Total
        {
            get { return total; }
            set
            {
                total = value;
            }
        }

        public int GetSuccess()
        {
            return success;
        }

        public void SetSuccess(int success)
        {
            if (success > total) throw new ArgumentException();
            this.success = success;
        }

       


    }

    class Properties
    {
        public static void Main()
        {
            var stat = new Statistics();
            stat.Total = 10;
            stat.Total++;
            stat.SetSuccess(stat.GetSuccess() + 1);
        }
    }
}