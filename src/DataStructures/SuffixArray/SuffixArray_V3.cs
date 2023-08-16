using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixArray
{
    public class SuffixArray_V3
    {
    }

    public class SuffixItemV3
    {
        public SuffixItemV3(int index)
        {
            Index = index;
        }

        public int Index { get; private set; }
        public int Rank { get; set; }
        public int NextRank { get; set; }
    }
}
