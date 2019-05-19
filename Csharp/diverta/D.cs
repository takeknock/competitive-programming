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
            List<long> divisors = new List<long>();
            for (long i = 1; i <= n / 2; i++)
            {
                if (divisors.Contains(i))
                {
                    break;
                }
                if (n % i == 0)
                {
                    divisors.Add(n / i);
                }
            }
            var res = divisors.Where(e => n / e == n % e);
            long ans = res.Sum();
            Console.WriteLine(ans);
        }
    }
}
