using DataStructures.SuffixArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.SuffixArray
{
    [TestClass]
    public class SufixArray_V2Tests
    {
        [TestMethod]
        public void Given_String_When_BuildSuffixArray_Then_ShouldReturnSuffixArray()
        {
            //Given
            var str = "banana";
            var suffixArray = new SuffixArray_V2();

            //When
            var actualResult = suffixArray.Build(str);

            //Then
            Assert.AreEqual(str.Length, actualResult.Length);
        }
    }
}
