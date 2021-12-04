using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DisjointSet
{
    public class DisjointSet_V4
    {
        private readonly int[] _values;
        public DisjointSet_V4(int[] values)
        {
            _values = values;
        }

        public void Union(int a, int b)
        {
            var rootA = _values[a];
            for (var index = 0; index < _values.Length; index++)
            {
                if (_values[index] == rootA)
                {
                    _values[index] = _values[b];
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
