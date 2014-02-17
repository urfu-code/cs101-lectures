using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01
{
    class S01 
    {
        static int[] values;
        static int totalSum;

        static bool Evaluate(bool[] subset)
        {
            var subValues = Enumerable
                .Range(0, subset.Length)
                .Where(z => subset[z])
                .Select(z => values[z])
                .ToArray();

            var sum = subValues.Sum();

            if (sum * 2 == totalSum)
            {
                Console.WriteLine("OK");
                foreach (var e in subValues) Console.Write(e+" ");
                Console.WriteLine(totalSum);
                return true;
             //   System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return false;
        }

        static void Subsets(bool[] subset, int index)
        {
            if (index == subset.Length)
            {
                Evaluate(subset);
                return;
            }
            subset[index] = true;
            Subsets(subset, index + 1);
            subset[index] = false;
            Subsets(subset, index + 1);
        }

        static void Subsets1(bool[] subset)
        {
            while (true)
            {
                Evaluate(subset);
                bool success = false;
                for (int j = subset.Length - 1; j >= 0; j--)
                    if (!subset[j])
                    {
                        success = true;
                        subset[j] = true;
                        for (int k=j+1;k<subset.Length;k++) 
                            subset[k]=false;
                        break;
                    }
                if (!success) break;
            }
        }

        static IEnumerable<bool[]> Subsets3(int N)
        {
            var subset = new bool[N];
            var list = new List<bool[]>();
            while (true)
            {
                list.Add(subset.ToArray());
                bool success = false;
                for (int j = subset.Length - 1; j >= 0; j--)
                    if (!subset[j])
                    {
                        success = true;
                        subset[j] = true;
                        for (int k = j + 1; k < subset.Length; k++)
                            subset[k] = false;
                        break;
                    }
                if (!success) break;
            }
            return list;
        }

        static IEnumerable<bool[]> Subsets4(int N)
        {
            var subset=new bool[N];
            while (true)
            {
                yield return subset.ToArray();
                bool success = false;
                for (int j = subset.Length - 1; j >= 0; j--)
                    if (!subset[j])
                    {
                        success = true;
                        subset[j] = true;
                        for (int k = j + 1; k < subset.Length; k++)
                            subset[k] = false;
                        break;
                    }
                if (!success) break;
            }
        }

        static IEnumerable<bool[]> Subsets5(int N)
        {
            //var max=(long)Math.Pow(2,N+1);
            var max=1<<(N+1);
            for (long number=0;number<max;number++)
            {
                var mask = 1;
                var subset=new bool[N];
                for (int j = N-1; j >=0; j--)
                {
                    subset[j] = (number & mask) != 0;
                    mask <<= 1;
                }
                yield return subset.ToArray();
               
            }
        }


        public static void MainX()
        {
            var rnd = new Random();
            values = Enumerable
                .Range(0, 20)
                .Select(z => rnd.Next(10))
                .ToArray();
            totalSum = values.Sum();
            if (totalSum % 2 == 1) { values[0]++; totalSum++; }
            //Subsets1(new bool[values.Length]);
            //foreach (var e in Subsets3(values.Length))
            //{
            //    if (Evaluate(e))
            //        break;
            //}

            foreach (var e in Subsets5(5))
            {
                foreach (var c in e) Console.Write(c ? 1 : 0);
                Console.WriteLine();
            }

        }
    }
}
