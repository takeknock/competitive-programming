using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompCsharp.ABC119
{
    class B
    {
        private const double BTCJPY = 380000.0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> ret = new List<double>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                double x = double.Parse(s[0]);
                if (s[1] == "BTC")
                {
                    x *= BTCJPY;
                }
                ret.Add(x);
            }

            Console.WriteLine(ret.Sum());

        }

    }
}
