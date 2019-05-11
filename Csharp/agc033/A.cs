using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.agc033
{
    class A
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int h = cin.NextInt();
            int w = cin.NextInt();
            string[] board = new string[h];
            int[,] numOfUpdate = new int[h, w]; // その場所が更新されるまでかかった回数

            int initial = 99999999;
            for (int i = 0; i < h; i++)
            {
                board[i] = cin.Next();
            }

            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (board[i][j] == '#')
                    {
                        numOfUpdate[i, j] = 0;
                        q.Enqueue(Tuple.Create(i, j));
                    }
                    else
                    {
                        numOfUpdate[i, j] = initial;
                    }
                }
            }

            int[] vy = new int[] { 1, 0, -1, 0 };
            int[] vx = new int[] { 0, 1, 0, -1 };

            while (q.Count > 0)
            {
                var now = q.Dequeue();
                int y = now.Item1;
                int x = now.Item2;
                for (int i = 0; i < vx.Length; i++)
                {
                    int nx = x + vx[i];
                    int ny = y + vy[i];
                    if (!IsInside(nx, ny, h, w))
                    {
                        continue;
                    }
                    if (numOfUpdate[ny, nx] != initial)
                    {
                        // already turned to be black.
                        continue;
                    }
                    numOfUpdate[ny, nx] = numOfUpdate[x, y] + 1;
                    q.Enqueue(Tuple.Create(ny, nx));
                }

            }

            int ans = 0;
            // extract max from numOfUpdate

            Console.WriteLine(ans);
        }

        private bool IsInside(int x, int y, int h, int w)
        {
            return 0 <= x && 0 <= y && y < h && x < w;
        }

    }
}
