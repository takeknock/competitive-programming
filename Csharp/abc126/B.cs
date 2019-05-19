using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.abc126
{
    class B
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            string s = cin.Next();

            int pre = int.Parse(s.Substring(0, 2));
            int suf = int.Parse(s.Substring(2, 2));

            if (1 <= pre && pre <= 12 && 1 <= suf && suf <= 12)
            {
                Console.WriteLine("AMBIGUOUS");
            }
            else if (pre == 0 && 1 <= suf && suf <= 12)
            {
                Console.WriteLine("YYMM");
            }
            else if (1 <= pre && pre <= 12 && suf == 0)
            {
                Console.WriteLine("MMYY");
            }
            else if (1 <= pre && pre <= 12 && 13 <= suf)
            {
                Console.WriteLine("MMYY");
            }
            else if (1 <= suf && suf <= 12 && 13 <= pre)
            {
                Console.WriteLine("YYMM");
            }
            else
            {
                Console.WriteLine("NA");
            }

        }
    }
}
