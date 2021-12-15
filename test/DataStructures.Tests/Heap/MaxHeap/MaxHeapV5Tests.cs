using DataStructures.Heap.MaxHeap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Heap.MaxHeap
{
    [TestClass]
    public class MaxHeapV5Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_Add_Then_ShouldAddItemsToMaxHeap()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var maxHeap = new MaxHeapV5(values.Length);

            //When
            foreach (var value in values)
            {
                maxHeap.Add(value);
            }

            //Then
            Assert.Inconclusive();
        }
    }
}
