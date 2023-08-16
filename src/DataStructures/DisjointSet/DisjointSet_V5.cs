using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DisjointSet
{
    public class DisjointSet_V5
    {
        private readonly int[] _values;
        public DisjointSet_V5(int size)
        {
            _values = new int[size];
            var count = 0;
            while (count < size)
            {
                _values[count] = count;
                count++;
            }
        }
        private int GetParent(int value)
        {
            while (_values[value] != value)
            {
                value = _values[value];
            }
            return value;
        }

        public void Union(int left, int right)
        { 
            var leftParent = GetParent(left);
            var rightParent = GetParent(right);
            _values[leftParent] = _values[rightParent];
        }

        public bool Find(int left, int right)
        {
            var leftParent = GetParent(left);
            var rightParent = GetParent(right);
            return leftParent == rightParent;
        }
    }
}
