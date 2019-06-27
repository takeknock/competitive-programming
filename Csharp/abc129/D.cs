using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.abc129
{
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
    class D
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int h = cin.NextInt();
            int w = cin.NextInt();
            height = h;
            width = w;
            string[] board = new string[h];
            int[,] l = new int[h, w];
            int[,] r = new int[h, w];
            int[,] u = new int[h, w];
            int[,] b = new int[h, w];

            for (int i = 0; i < h; i++)
            {
                board[i] = cin.Next();
            }

            int max = 0;
            for (int ri = 0; ri < h; ri++)
            {
                for (int ci = 0; ci < w; ci++)
                {
                    int count = 1;

                    max = max < count ? count : max;
                }
            }
            Console.WriteLine(max);
        }

        int height, width;
        bool IsInside(int row, int column)
        {
            if (0 <= row && row < height && 0 <= column && column < width)
            {
                return true;
            }
            return false;
        }

    }

    public class Board
    {
        private readonly int h;
        private readonly int w;
        private string[] board;
        private int[,] up;
        private int[,] down;
        private int[,] left;
        private int[,] right;

        Board(int height, int width, string[] contents)
        {
            h = height;
            w = width;
            board = contents;
        }

        void Initialize()
        {
            up = new int[h, w];
            down = new int[h, w];
            left = new int[h, w];
            right = new int[h, w];
        }

        public int NumOfReachablesToUp(int h, int w)
        {
            return up[h, w];
        }
        public int NumOfReachablesToBottom(int h, int w)
        {
            return down[h, w];
        }
        public int NumOfReachablesToRight(int h, int w)
        {
            return right[h, w];
        }
        public int NumOfReachablesToLeft(int h, int w)
        {
            return left[h, w];
        }

        void CountReachables()
        {
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++)
                {
                    if ('#' == board[j][i])
                        left[j, i] = 0;
                    else if (j == 0)
                        left[0, i] = 1;
                    else
                        left[j, i] = left[j - 1, i] + 1;
                }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if ('#' == board[w - 1 - j][i])
                        right[w - 1 - j, i] = 0;
                    else if (j == 0)
                        right[w - 1, i] = 1;
                    else
                        right[w - 1 - j, i] = right[w - j, i] + 1;
                }

            }

            for (int j = 0; j < w; j++)
            {
                for (int i = 0; i < h; i++)
                {
                    if ('#' == board[j][i])
                        up[j, i] = 0;
                    else if (i == 0)
                        up[j, 0] = 1;
                    else
                        up[j, i] = up[j, i - 1] + 1;
                }
            }

            for (int j = 0; j < w; j++)
            {
                for (int i = 0; i < h; i++)
                {
                    if ('#' == board[j][h - i - 1])
                        down[j, h - 1 - i] = 0;
                    else if (i == 0)
                        down[j, h - 1] = 1;
                    else
                        down[j, h - i - 1] = down[j, h - i] + 1;
                }
            }
        }

    }


}
