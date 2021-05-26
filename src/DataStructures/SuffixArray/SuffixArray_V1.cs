using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/suffix-array-set-1-introduction/
    /// https://www.geeksforgeeks.org/suffix-array-set-2-a-nlognlogn-algorithm/
    /// </summary>
    public class SuffixArray_V1
    {
        public string[] ConstructSuffixArray(string str)
        {
            var suffixArray = new string[str.Length];
            for (var index = 0; index < str.Length; index++)
            {
                suffixArray[index] = str.Substring(index);
            }
            Array.Sort(suffixArray);
            return suffixArray;
        }
    }
}
