using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.abc126
{
    class A
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int n = cin.NextInt();
            int k = cin.NextInt();
            string s = cin.Next();
            int index = k - 1;

            char[] tmp = s.ToCharArray();
            tmp[index] = Char.ToLower(s[index]);
            Console.WriteLine(tmp);



        }
    }
}
