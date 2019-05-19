﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        new Program().Solve();
    }

    void Solve()
    {
        Scanner cin = new Scanner();
        int n = cin.NextInt();
        int k = cin.NextInt();

        double prob = 0.0;
        for (int i = 1; i <= n; i++)
        {
            long tmp = i;
            double thisProb = 1.0;
            while(tmp < k)
            {
                tmp *= 2;
                thisProb *= 0.5;
            }
            prob += thisProb / n;
        }
        Console.WriteLine(prob);
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