using System;
using System.Collections.Generic;

namespace CsharpLibrary
{
    public class MMath
    {
        /// <summary>
        ///  O(log n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int LCM(int a, int b)
        {
            int gcd = GCD(a, b);
            return a * b / gcd;
        }

        /// <summary>
        ///  calculate gcd in O(log n).
        /// </summary>
        /// <param name="a">a must be equal or larger than b.</param>
        /// <param name="b"></param>
        /// <returns></returns>
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

        /// <summary>
        ///   create divisors (O(sqrt(n)))
        /// </summary>
        /// <param name="n">number you wank to know divisors</param>
        /// <returns>divisors IEnumerable</returns>
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
