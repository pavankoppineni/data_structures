using DataStructures.Tree.BinaryIndexedTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Tree.BinaryIndexedTree
{
    [TestClass]
    public class BinaryIndexedTree_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindRangeSum_Then_CalcualteSumBetweenGivenRanges()
        {
            //Given
            var values = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            var binaryIndexedTree = new BinaryIndexedTree_V2(values);
            var expectedResult = 6;

            //When
            var actualResult = binaryIndexedTree.GetRangeSum(2, 7);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
