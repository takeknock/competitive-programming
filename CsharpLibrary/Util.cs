using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLibrary
{
    public class Util
    {
        public static void Swap(ref int a, ref int b)
        {
            a ^= b; // a = a ^ b
            b ^= a; // b = b ^ (a ^ b) // this is a.
            a ^= b; // a = (a ^ b) ^ (b ^ (a ^ b)) // this is b.
        }
    }
}
