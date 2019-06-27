using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.msol
{
    class D
    {
        void Solve()
        {
            Scanner cin = new Scanner();
            int n = cin.NextInt();
            //int[] a = new int[n];
            //int[] b = new int[n];
            int[] c = new int[n];

            List<Vertex> g = new List<Vertex>();
            for (int i = 0; i < n; i++)
            {
                g.Add(new Vertex());
            }
            for (int i = 0; i < n - 1; i++)
            {
                int a = cin.NextInt() - 1;
                int b = cin.NextInt() - 1;
                g[a].edge.Add(g[b]);
                //g[b].edge.Add(g[a]);
            }
            for (int i = 0; i < n; i++)
            {
                c[i] = cin.NextInt();
            }

            Array.Sort(c);
            Array.Reverse(c);

            List<Vertex> sorted = g.OrderByDescending(e => e.edge.Count()).ToList();
            for (int i = 0; i < n; i++)
            {
                sorted[i].cost = c[i];
            }
            long score = CalculateScore(sorted);

            Console.WriteLine(score);
        }

        long CalculateScore(List<Vertex> g)
        {
            long score = 0;
            foreach (var v in g)
            {
                foreach (var cv in v.edge)
                {
                    score += Math.Min(cv.cost, v.cost);
                }
            }
            return score;
        }
    }
    class Vertex
    {
        public Vertex()
        {
            edge = new List<Vertex>();
        }
        public List<Vertex> edge
        {
            get; set;
        }
        public int cost
        {
            get; set;
        }
    }
}
