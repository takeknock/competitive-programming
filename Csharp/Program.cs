using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

class Program
{
    const int MOD = 1000000007;
    static void Main(string[] args)
    {
        new Program().Solve();
    }

    void Solve()
    {
        Scanner cin = new Scanner();
        int n = cin.NextInt();
        int t = cin.NextInt();
        //int[] x = new int[n];
        //int[] y = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    x[i] = cin.NextInt();
        //    y[i] = cin.NextInt();
        //}

        Util.Swap(ref n, ref t);
        Console.WriteLine("{0} {1}", n, t);
        
    }

}

class Util
{
    public static void Swap(ref int a, ref int b)
    {
        a ^= b; // a = a ^ b
        b ^= a; // b = b ^ (a ^ b) // this is a.
        a ^= b; // a = (a ^ b) ^ (b ^ (a ^ b)) // this is b.
    }
}

class UnionFind
{
    private List<int> parentVertexes = new List<int>();

    UnionFind(int n)
    {
        parentVertexes = Enumerable.Repeat(-1, n).ToList();
    }

    int Root(int vi)
    {
        if(parentVertexes[vi] < 0)
        {
            return vi;
        }

        return Root(parentVertexes[vi]);

    }

    bool IsSame(int x, int y)
    {
        return Root(x) == Root(y);
    }

    bool Merge(int x, int y)
    {
        if (IsSame(x, y))
        {
            return false;
        }
        if (parentVertexes[x] > parentVertexes[y])
        {
            // merge technique
            Util.Swap(ref x, ref y);
        }

        parentVertexes[x] += parentVertexes[y];
        parentVertexes[y] = x;
        return true;
    }

}


class Scanner
{
    string[] s;
    int i;

    char[] cs = new char[] { ' ' };

    public Scanner()
    {
        s = new string[0];
        i = 0;
    }

    public string Next()
    {
        if (i < s.Length) return s[i++];
        string st = Console.ReadLine();
        while (st == "") st = Console.ReadLine();
        s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
        if (s.Length == 0) return Next();
        i = 0;
        return s[i++];
    }

    public int NextInt()
    {
        return int.Parse(Next());
    }

    public char[] ArrayChar()
    {
        return Next().ToCharArray();
    }
    public int[] ArrayInt(int N, int add = 0)
    {
        int[] Array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Array[i] = NextInt() + add;
        }
        return Array;
    }

    public long NextLong()
    {
        return long.Parse(Next());
    }

    public long[] ArrayLong(int N, long add = 0)
    {
        long[] Array = new long[N];
        for (int i = 0; i < N; i++)
        {
            Array[i] = NextLong() + add;
        }
        return Array;
    }

    public double NextDouble()
    {
        return double.Parse(Next());
    }


    public double[] ArrayDouble(int N, double add = 0)
    {
        double[] Array = new double[N];
        for (int i = 0; i < N; i++)
        {
            Array[i] = NextDouble() + add;
        }
        return Array;
    }
}

