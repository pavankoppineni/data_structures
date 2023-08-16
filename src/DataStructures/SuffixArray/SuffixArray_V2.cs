using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixArray
{
    public class SuffixArray_V2
    {
        public SuffixItem[] Build(string str)
        {
            var suffixItems = new SuffixItem[str.Length];
            suffixItems[0] = new SuffixItem(0, str[0] - 'a', -1);
            var index = 1;
            while (index < str.Length)
            {
                suffixItems[index] = new SuffixItem(index, str[index] - 'a', -1);
                suffixItems[index - 1].NextRank = suffixItems[index].Rank;
                index++;
            }
            Array.Sort(suffixItems, SuffixItem.Comparer);
            return suffixItems;
        }
    }

    public struct SuffixItem : IComparer<SuffixItem>
    {
        public static SuffixItem Comparer = new SuffixItem();
        public SuffixItem(int index, int rank, int nextRank)
        {
            Index = index;
            Rank = rank;
            NextRank = nextRank;
        }

        public int Index { get; set; }
        public int Rank { get; set; }
        public int NextRank { get; set; }

        public int Compare(SuffixItem x, SuffixItem y)
        {
            if (x.Rank == y.Rank)
            {
                return x.NextRank.CompareTo(y.NextRank);
            }
            return x.Rank.CompareTo(y.Rank);
        }
    }
}
