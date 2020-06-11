using DataStructures.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class QueueV3Tests
    {
        [TestMethod]
        public void Given_Queue_When_AddElementsAndDeleteElements_Then_ElementsShouldBeRemovedInOrderTheyAreAdded()
        {
            //Given
            var length = 5;
            var queue = new QueueV3(length);
            var expectedValues = new int[] { 10, 19, 8, 9, 1 };
            var actualValues = new List<int>();

            //When
            foreach (var value in expectedValues)
            {
                queue.EnQueue(value);
            }

            foreach (var value in expectedValues)
            {
                actualValues.Add(queue.DeQueue());
            }

            //Then
            for (var i = 0; i < expectedValues.Length; i++)
            {
                var expectedValue = expectedValues[i];
                var actualValue = actualValues[i];
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
