using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DisjointSet
{
    /// <summary>
    /// https://www.hackerearth.com/practice/notes/disjoint-set-union-union-find/
    /// </summary>
    public class DisjointSet_V1
    {
        private readonly int[] _values;
        public DisjointSet_V1(int n)
        {
            _values = new int[n];
            for (var index = 0; index < n; index++)
            {
                _values[index] = index;
            }
        }

        public void Union(int a, int b)
        {
            var rootA = _values[a];
            for (var i = 0; i < _values.Length; i++)
            {
                if (_values[i] == rootA)
                {
                    _values[i] = _values[b];
                }
            }
        }

        public bool Find(int a, int b)
        {
            var rootA = _values[a];
            var rootB = _values[b];
            return rootA == rootB;
        }
    }
}
