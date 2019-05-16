using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.diverta
{
    class D
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            long n = cin.NextLong();

            List<long> res = new List<long>();
            //long sqrt = Math.Sqrt(n);
            for (long i = 1; i <= n; i++)
            {
                if (n / i == n % i)
                {
                    res.Add(i);
                }
            }

            long total = res.Sum();
            Console.WriteLine(total);
        }
    }
}
