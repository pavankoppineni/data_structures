using DataStructures.DisjointSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.DisjointSet
{
    [TestClass]
    public class DisjointSet_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_ConstructDisjointSet_Then_ShouldGenerateDisjointSet()
        {
            //Given
            var disjointSet = new DisjointSet_V1(4);
            var expectedResult_13 = true;
            var expectedResult_02 = false;

            //When
            disjointSet.Union(0, 3);
            disjointSet.Union(1, 3);
            var actualResult_02 = disjointSet.Find(0, 2);
            var actualResult_13 = disjointSet.Find(1, 3);

            //Then
            Assert.AreEqual(expectedResult_02, actualResult_02);
            Assert.AreEqual(expectedResult_13, actualResult_13);
        }
    }
}
