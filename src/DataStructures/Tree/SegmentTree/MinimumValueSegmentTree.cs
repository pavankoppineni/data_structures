using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.SegmentTree
{
    /// <summary>
    /// Segment Tree Data Structure
    /// </summary>
    public class MinimumValueSegmentTree
    {
        public int[] ConstructTree(int[] values)
        {
            var segmentArray = new int[7];
            ConstructTree(values, segmentArray, 0, values.Length - 1, 0);
            return segmentArray;
        }

        private void ConstructTree(int[] values, int[] segmentArray, int low, int high, int position)
        {
            if (low == high)
            {
                segmentArray[position] = values[low];
                return;
            }
            var mid = (low + high) / 2;
            var left = (2 * position) + 1;
            var right = (2 * position) + 2;
            ConstructTree(values, segmentArray, low, mid, left);
            ConstructTree(values, segmentArray, mid + 1, high, right);
            segmentArray[position] = Math.Min(segmentArray[left], segmentArray[right]);
        }
    }
}
