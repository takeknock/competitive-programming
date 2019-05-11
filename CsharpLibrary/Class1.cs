using System;

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
    }
}
