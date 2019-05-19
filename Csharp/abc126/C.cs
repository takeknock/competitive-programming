using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.abc126
{
    class C
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int n = cin.NextInt();
            int[] u = new int[n];
            int[] v = new int[n];
            long[] w = new long[n];

            for (int i = 0; i < n - 1; i++)
            {
                u[i] = cin.NextInt();
                v[i] = cin.NextInt();
                w[i] = cin.NextLong();
            }

        }
    }
}
