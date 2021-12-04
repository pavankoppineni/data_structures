using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BinaryIndexedTree
{
    /// <summary>
    /// https://www.geeksforgeeks.org/binary-indexed-tree-or-fenwick-tree-2/
    /// </summary>
    public class BinaryIndexedTree_V2
    {
        private int[] _values;
        private int[] _indexArray;
        public BinaryIndexedTree_V2(int[] values)
        {
            _values = values;
            _indexArray = new int[values.Length + 1];
            for (var index = 1; index < _indexArray.Length; index++)
            {
                AddValue(index);
            }
        }

        private void AddValue(int index)
        {
            var value = _values[index - 1];
            do
            {
                _indexArray[index] += value;
                var lowestBit = index & -index;
                index += lowestBit;
            }
            while (index <= _indexArray.Length);
        }

        public int GetRangeSum(int min, int max)
        {
            var minSum = GetSum(min + 1);
            var maxSum = GetSum(max + 1);
            return maxSum - minSum;
        }

        private int GetSum(int index)
        {
            var sum = 0;
            do
            {
                sum += _indexArray[index];
                index -= index & -index;
            } while (index > 0);
            return sum;
        }
    }
}
