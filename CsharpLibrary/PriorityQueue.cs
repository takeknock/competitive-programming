using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CsharpLibrary
{
    static class Func
    {
        public static Comparison<T> ToComparison<T>(this IComparer<T> comp) => comp == null ? DefaultComparison<T>() : (x, y) => comp.Compare(x, y);
        public static Comparison<T> DefaultComparison<T>() => (x, y) => Comparer<T>.Default.Compare(x, y);
    }
    class PriorityQueue<T> : IEnumerable<T>, ICollection, IEnumerable, ICloneable
    {
        Comparison<T> comp;
        List<T> list;
        public int Count { get; private set; } = 0;
        public bool IsEmpty => Count == 0;
        public PriorityQueue(IEnumerable<T> source) : this((Comparison<T>)null, 0, source) { }
        public PriorityQueue(int capacity = 4, IEnumerable<T> source = null) : this((Comparison<T>)null, capacity, source) { }
        public PriorityQueue(IComparer<T> comp, IEnumerable<T> source) : this(comp.ToComparison(), source) { }
        public PriorityQueue(IComparer<T> comp, int capacity = 4, IEnumerable<T> source = null) : this(comp.ToComparison(), source) { list.Capacity = capacity; }
        public PriorityQueue(Comparison<T> comp, IEnumerable<T> source) : this(comp, 0, source) { }
        public PriorityQueue(Comparison<T> comp, int capacity = 4, IEnumerable<T> source = null) { this.comp = comp ?? Func.DefaultComparison<T>(); list = new List<T>(capacity); if (source != null) foreach (var x in source) Enqueue(x); }
        /// <summary>
        /// add an item
        /// this is an O(log n) operation
        /// </summary>
        /// <param name="x">item</param>
        public void Enqueue(T x)
        {
            var pos = Count++;
            list.Add(x);
            while (pos > 0)
            {
                var p = (pos - 1) / 2;
                if (comp(list[p], x) <= 0) break;
                list[pos] = list[p];
                pos = p;
            }
            list[pos] = x;
        }
        /// <summary>
        /// return the minimum element and remove it
        /// this is an O(log n) operation
        /// </summary>
        /// <returns>the minimum</returns>
        public T Dequeue()
        {
            var value = list[0];
            var x = list[--Count];
            list.RemoveAt(Count);
            if (Count == 0) return value;
            var pos = 0;
            while (pos * 2 + 1 < Count)
            {
                var a = 2 * pos + 1;
                var b = 2 * pos + 2;
                if (b < Count && comp(list[b], list[a]) < 0) a = b;
                if (comp(list[a], x) >= 0) break;
                list[pos] = list[a];
                pos = a;
            }
            list[pos] = x;
            return value;
        }
        /// <summary>
        /// look at the minimum element
        /// this is an O(1) operation
        /// </summary>
        /// <returns>the minimum</returns>
        public T Peek() => list[0];
        public IEnumerator<T> GetEnumerator() { var x = (PriorityQueue<T>)Clone(); while (x.Count > 0) yield return x.Dequeue(); }
        void CopyTo(Array array, int index) { foreach (var x in this) array.SetValue(x, index++); }
        public object Clone() { var x = new PriorityQueue<T>(comp, Count); x.list.AddRange(list); return x; }
        public void Clear() { list = new List<T>(); Count = 0; }
        public void TrimExcess() => list.TrimExcess();
        /// <summary>
        /// check whether item is in this queue
        /// this is an O(n) operation
        /// </summary>
        public bool Contains(T item) => list.Contains(item);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        void ICollection.CopyTo(Array array, int index) => CopyTo(array, index);
        bool ICollection.IsSynchronized => false;
        object ICollection.SyncRoot => this;
    }
}
