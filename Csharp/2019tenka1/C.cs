using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._2019tenka1
{
    class C
    {
        void c(string[] args)
        {
            new C().Solve();
        }

        void Solve()
        {
            Scanner cin = new Scanner();
            int N = cin.NextInt();
            string s = cin.Next();
            char[] temp = s.ToArray();
            var reversed = s.Reverse().ToArray();
            bool flag = false;
            int rightblack = 0;
            int rightwhite = 0;

            for (int i = 0; i < N - 1; ++i)
            {

                if (reversed[i] == '#' && reversed[i + 1] == '.')
                {
                    flag = true;
                }
                if (reversed[i] == '#')
                {
                    rightblack++;
                }
                else
                {
                    rightwhite++;
                }

                if (flag)
                {
                    break;
                }
            }

            int rem = rightblack + rightwhite;

            string sub = s.Substring(0, N - rem);

            //int white = sub.Where(e => e == '.').Count();
            int black = sub.Where(e => e == '#').Count();


            int[] dp = Enumerable.Repeat(0, N).ToArray();
            for (int i = 1; i < N; ++i)
            {
                if (temp[i - 1] == '#' && temp[i] == '.')
                {
                    dp[i] = dp[i - 1] + 1;
                    temp[i] = '#';
                }
                else
                {
                    dp[i] = dp[i - 1];
                }
            }

            int min = Math.Min(dp[N - rem], black);
            int ans = rightwhite + dp[N - rem];

            //int blackrem = 0;
            //bool blackf = false;


            //int whiteright = 0;
            //for (int i = 0; i < N; ++i)
            //{
            //    if (reversed[i] == '.')
            //    {
            //        whiteright++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //int black = s.Where(e => e == '#').Count() - blackrem + whiteright;

            //int ans = black >= dp.Last() ? dp.Last() : black;

            Console.WriteLine(ans);

        }
    }
}
