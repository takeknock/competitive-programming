using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.abc128
{
    class C
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int n = cin.NextInt();
            int m = cin.NextInt();
            bool[] f = Enumerable.Repeat(true, n).ToArray();

            List<int>[] s = new List<int>[m];
            int[] p = new int[m];

            for (int i = 0; i < m; i++)
            {
                int k = cin.NextInt();
                for (int j = 0; j < k; j++)
                {
                    s[i].Add(cin.NextInt());
                }
            }

            for (int i = 0; i < m; i++)
            {
                p[i] = cin.NextInt();
            }


        }

    }
}
