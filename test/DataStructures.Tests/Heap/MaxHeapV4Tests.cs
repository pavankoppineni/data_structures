using DataStructures.Heap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Heap
{
    [TestClass]
    public class MaxHeapV4Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Heapify_Then_ShouldReturnMaxHeap()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5 };
            var problem = new MaxHeapV4(values);
            var expectedValues = new int[] { 5, 4, 3, 1, 2 };

            //When
            var actualValues = problem.Heapify();

            //Then
            Assert.AreEqual(expectedValues.Length, actualValues.Length);
            for (var index = 0; index < expectedValues.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
