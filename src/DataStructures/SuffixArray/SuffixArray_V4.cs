using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixArray
{
    public class SuffixArray_V4
    {
        public SuffixItem_V4[] Build(string str)
        {
            var suffixItemArray = new SuffixItem_V4[str.Length];
            suffixItemArray[0] = new SuffixItem_V4(0, str[0] - 'a');
            var previousSuffixItem = suffixItemArray[0];
            for (var index = 1; index < str.Length; index++)
            {
                var currentSuffixItem = new SuffixItem_V4(index, str[index] - 'a');
                previousSuffixItem.NextRank = currentSuffixItem.Rank;
                previousSuffixItem = currentSuffixItem;
                suffixItemArray[index] = currentSuffixItem;
            }
            return suffixItemArray;
        }
    }

    public class SuffixItem_V4 : IComparable<SuffixItem_V4>
    {
        private readonly int _index;
        public SuffixItem_V4(int index, int rank)
        {
            _index = index;
            Rank = rank;
        }

        public int Index => _index;
        public int Rank { get; set; }
        public int NextRank { get; set; }

        public int CompareTo(SuffixItem_V4 other)
        {
            throw new NotImplementedException();
        }
    }
}
