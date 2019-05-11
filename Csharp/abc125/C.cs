using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.abc125
{
    class C
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int N = cin.NextInt();
            long[] A = cin.ArrayLong(N);
            long[] gcd = new long[N + 2]; // gcd[i] is gcd with removing i-th number 
            long[] L = new long[N + 2];
            long[] R = new long[N + 2];

            L[0] = A[0];
            R[N - 1] = A[N - 1];

            for (int i = 0; i < N - 1; ++i)
            {
                L[i + 1] = CalcGCD(L[i], A[i + 1]);
            }
            for (int i = N - 2; 0 <= i; --i)
            {
                R[i] = CalcGCD(R[i + 1], A[i]);
            }

            long ans = Math.Max(L[N - 2], R[1]);
            for (int i = 1; i < N - 1; ++i)
            {
                long tmp = CalcGCD(L[i - 1], R[i + 1])/*without i-th*/;

                //long tmp = Math.Max(
                //    CalcGCD(L[i], R[i + 1])/*without i-th*/,
                //    CalcGCD(L[i], R[i])/*with i-th*/);
                ans = ans <= tmp ? tmp : ans;
            }

            Console.WriteLine(ans);
        }

        private long CalcGCD(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            if (a == 0)
            {
                return b;
            }
            if (a < b)
            {
                long residual = b % a;
                return CalcGCD(a, residual);
            }
            else
            {
                long residual = a % b;
                return CalcGCD(b, residual);
            }
        }
    }
}
