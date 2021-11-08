using DataStructures.DisjointSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.DisjointSet
{
    [TestClass]
    public class DisjointSet_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_ConstructDisjointSet_Then_ShouldReturnDisjointSet()
        {
            //Given
            var values = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var disjointSet = new DisjointSet_V2(values);

            //When
            disjointSet.Union(2, 1);
            disjointSet.Union(4, 3);
            disjointSet.Union(8, 4);
            disjointSet.Union(9, 3);
            disjointSet.Union(6, 5);

            //Then
            Assert.AreEqual(true, disjointSet.Find(3, 8));
            Assert.AreEqual(false, disjointSet.Find(1, 6));
        }
    }
}
