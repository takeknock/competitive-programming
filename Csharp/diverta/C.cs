using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.diverta
{
    class C
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int n = cin.NextInt();
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = cin.Next();
            }

            int count = 0;

            List<int> a = new List<int>();
            List<int> b = new List<int>();
            List<int> c1 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                bool flag = true;
                string thisS = s[i].Clone() as string;
                while (flag)
                {
                    int index = thisS.IndexOf("AB");
                    if (index < 0)
                    {
                        flag = false;
                    }
                    if (index >= 0)
                    {
                        int length = thisS.Length;
                        thisS = thisS.Substring(index + 2, length - index - 2).Clone() as string;
                        count++;
                    }
                }
                int lastIndex = s[i].Length - 1;
                if (s[i][0] == 'B' && s[i][lastIndex] == 'A')
                {
                    c1.Add(i);
                    continue;
                }
                if (s[i][lastIndex] == 'A')
                {
                    a.Add(i);
                }
                if (s[i][0] == 'B')
                {
                    b.Add(i);
                }
            }

            int ans = count;
            if (c1.Count == 0)
            {
                ans += Math.Min(a.Count, b.Count);
            }
            else if (a.Count + b.Count > 0)
            {
                ans += c1.Count + Math.Min(a.Count, b.Count);
            }
            else
            {
                ans += c1.Count - 1;
            }
            Console.WriteLine(ans);
        }
    }
}
