using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DisjointSet
{
    public class DisjointSet_V3
    {
        private int[] _values;
        public DisjointSet_V3(int[] values)
        {
            _values = values;
        }

        private int GetParent(int a)
        {
            while (_values[a] != a)
            {
                a = _values[a];
            }
            return a;
        }

        public void Union(int a, int b)
        {
            var parentA = GetParent(a);
            var parentB = GetParent(b);
            _values[parentA] = _values[parentB];
        }

        public bool Find(int a, int b)
        {
            var parentA = GetParent(a);
            var parentB = GetParent(b);
            return parentA == parentB;
        }
    }
}
