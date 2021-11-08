using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DisjointSet
{
    /// <summary>
    /// https://www.hackerearth.com/practice/notes/disjoint-set-union-union-find/
    /// </summary>
    public class DisjointSet_V2
    {
        private int[] _values;
        public DisjointSet_V2(int[] values)
        {
            _values = values;
        }

        public void Union(int a, int b)
        {
            var groupA = _values[a];
            for (var index = 0; index < _values.Length; index++)
            {
                var value = _values[index];
                if (value == groupA)
                {
                    _values[index] = _values[b];
                }
            }
        }

        public bool Find(int a, int b)
        {
            return _values[a] == _values[b];
        }
    }
}
