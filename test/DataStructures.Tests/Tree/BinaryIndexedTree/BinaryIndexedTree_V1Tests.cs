using DataStructures.Tree.BinaryIndexedTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Tree.BinaryIndexedTree
{
    [TestClass]
    public class BinaryIndexedTree_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_BuildBinaryIndexedTree_Then_ShouldReturnBinaryIndexedTree()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5, 6 };
            var problem = new BinaryIndexedTree_V1();
            var expectedResult = new int[] { 0, 1, 3, 3, 10 };

            //When
            var actualResult = problem.BuildTree(values);
            var sum = problem.GetSum(1, 5);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            for(var index = 0; index < expectedResult.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
