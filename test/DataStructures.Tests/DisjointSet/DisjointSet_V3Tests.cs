using DataStructures.DisjointSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.DisjointSet
{
    [TestClass]
    public class DisjointSet_V3Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_ConstructDisjointSet_Then_ShouldReturnDisjointSet()
        {
            //Given
            var values = new int[] { 0, 1, 2, 3, 4 };
            var disjointSet = new DisjointSet_V3(values);

            //When
            disjointSet.Union(0, 4);
            disjointSet.Union(1, 4);
            disjointSet.Union(1, 2);

            //Then
            Assert.AreEqual(true, disjointSet.Find(0, 2));
            Assert.AreEqual(false, disjointSet.Find(1, 3));
        }
    }
}
