using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompCsharp.ABC119
{
    class A
    {
        //static void Main(string[] args)
        //{
        //    string[] s = Console.ReadLine().Split('/');
        //    int year = int.Parse(s[0]);
        //    int month = int.Parse(s[1]);
        //    int day = int.Parse(s[2]);

        //    if (IsHeisei(year, month, day))
        //    {
        //        Console.WriteLine("Heisei");
        //    }
        //    else
        //    {
        //        Console.WriteLine("TBD");
        //    }

        //}

        static bool IsHeisei(int year, int month, int day)
        {
            if (year >= 2020)
            {
                return false;
            }

            if (year == 2019 && month >= 5)
            {
                return false;
            }

            return true;

        }

    }
}
