using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01
{
    class S04
    {

        public static void Permutations1(int[] perm, int n)
        {
            if (n == perm.Length)
            {
                foreach (var e in perm)
                    Console.Write(e);
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < perm.Length; i++)
            {
                bool ok = true;
                for (int j=0;j<n;j++)
                    if (perm[j] == i) { ok = false; break; }
                if (!ok) continue;
                perm[n] = i;
                Permutations1(perm, n + 1);
            }
        }

        public static void Main()
        {
            Permutations1(new int[4], 0);
        }

    }
}
