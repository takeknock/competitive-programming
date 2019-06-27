using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CsharpLibrary
{
    class UnionFind
    {
        private List<int> parentVertexes = new List<int>();

        public UnionFind(int n)
        {
            Init(n);
        }

        public void Init(int n)
        {
            parentVertexes = Enumerable.Repeat(-1, n).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexIndex">target vertex</param>
        /// <returns>index of root vertex</returns>
        public int Root(int vertexIndex)
        {
            if (parentVertexes[vertexIndex] < 0)
            {
                return vertexIndex;
            }

            parentVertexes[vertexIndex] = Root(parentVertexes[vertexIndex]);
            return parentVertexes[vertexIndex];

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">target</param>
        /// <param name="y"></param>
        /// <returns>both belong in same group or not</returns>
        public bool IsSame(int x, int y)
        {
            return Root(x) == Root(y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">target vertex index</param>
        /// <param name="y">target vertex index</param>
        /// <returns>whether groups are merged successfully or not</returns>
        public bool Merge(int x, int y)
        {
            // replace targets with roots
            x = Root(x);
            y = Root(y);
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertexIndex">target index</param>
        /// <returns>the size in which target vertex belongs</returns>
        public int Size(int vertexIndex)
        {
            return -parentVertexes[Root(vertexIndex)];
        }
    }
}
