using DataStructures.DisjointSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.DisjointSet
{
    [TestClass]
    public class DisjointSet_V4Tests
    {   
        [TestMethod]
        public void Given_DisjointSetAndAddedFirstAndSecondToSameSet_When_FindFirstAndSecond_Then_ShouldReturnTrue()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4 };
            var disjointSet = new DisjointSet_V4(values);
            var expectedResult = true;

            //When
            disjointSet.Union(0, 1);
            var actualResult = disjointSet.Find(0, 1);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Given_DisjointSetAndAddedFirstAndThirdToSameSet_When_FindFirstAndSecond_Then_ShouldReturnFalse()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4 };
            var disjointSet = new DisjointSet_V4(values);
            var expectedResult = false;

            //When
            disjointSet.Union(0, 2);
            var actualResult = disjointSet.Find(0, 1);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
