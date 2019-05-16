using System;
using System.Collections.Generic;

namespace CsharpLibrary
{
    public class MMath
    {
        static int GCD(int a, int b)
        {
            var c = 1;
            while (c != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

        static IEnumerable<int> MakeDivisors(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 0; i < Math.Sqrt(n)+1; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i != n / i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }
            return divisors;
        }
    }
}
