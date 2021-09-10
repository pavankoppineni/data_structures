using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BinaryIndexedTree
{
    public class BinaryIndexedTree_V1
    {
        private int[] _values;
        private int[] _tree;

        public int GetSum(int left, int right)
        {
            var rightSum = GetSum(right);
            var leftSum = GetSum(left - 1);
            return rightSum - leftSum;
        }

        private int GetSum(int index)
        {
            if (index < 0)
            {
                return 0;
            }

            if (index == 0)
            {
                return _tree[index + 1];
            }
            var sum = 0;
            index += 1;
            while (index > 0)
            {
                sum += _tree[index];
                index -= index & -index;
            }

            return sum;
        }

        public void Update(int index, int value)
        {

        }

        public int[] BuildTree(int[] values)
        {
            _values = values;
            _tree = new int[values.Length + 1];
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                var treeIndex = index + 1;
                while (treeIndex < _tree.Length)
                {
                    _tree[treeIndex] += value;
                    treeIndex += treeIndex & (-treeIndex);
                }
            }

            return _tree;
        }
    }
}
