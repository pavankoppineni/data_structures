using DataStructures.SuffixTrie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.SuffixTrie
{
    [TestClass]
    public class SuffixTrie_V1Tests
    {
        [TestMethod]
        public void Given_StringPattern_When_ConstructSuffixTrie_Then_ShouldReturnSuffixTrie()
        {
            //Given
            var pattern = "nana";
            var suffiTrie = new SuffixTrie_V1(pattern);

            //When
            var actualTrieNode = suffiTrie.Construct();

            //Then
            Assert.Inconclusive();
        }
    }
}
