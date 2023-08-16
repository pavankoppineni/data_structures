using DataStructures.DisjointSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.DisjointSet
{
    [TestClass]
    public class DisjointSet_V5Tests
    {
        [TestMethod]
        public void DisjointSetTestOne()
        {
            //Given
            var size = 5;
            var left = 0;
            var right = 4;
            var disjointSet = new DisjointSet_V5(size);
            
            //When
            disjointSet.Union(left, right);
            var actualResult = disjointSet.Find(left, right);

            //Then
            Assert.AreEqual(true, actualResult);
        }
    }
}
