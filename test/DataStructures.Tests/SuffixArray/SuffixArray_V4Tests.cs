using DataStructures.SuffixArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.SuffixArray
{
    [TestClass]
    public class SuffixArray_V4Tests
    {
        [TestMethod]
        public void Given_String_When_BuildSuffixArray_Then_ShouldReturnSuffixArray()
        {
            //Given
            var str = "banana";
            var suffixArray = new SuffixArray_V4();

            //When
            var suffixArrayItems = suffixArray.Build(str);

            //Then
            Assert.Inconclusive();
        }
    }
}
