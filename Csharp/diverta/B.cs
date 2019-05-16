using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.diverta
{
    class B
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int R = cin.NextInt();
            int G = cin.NextInt();
            int B = cin.NextInt();
            int N = cin.NextInt();

            int MAX = 3000;
            int count = 0;
            for (int r = 0; r <= MAX; r++)
            {
                for (int g = 0; g <= MAX; g++)
                {
                    int residual = N - R * r - G * g;
                    if (residual < 0)
                    {
                        break;
                    }
                    if (residual % B == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }

}
