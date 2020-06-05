using DataStructures.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class QueueV2Tests
    {
        [TestMethod]
        public void Given_CreateQueue_When_EnQueueFiveItemsAndDeQueueFiveItems_Then()
        {
            //Given
            var length = 5;
            var queue = new QueueV2(length);
            var expectedValues = new List<int> { 1, 2, 3, 4, 5 };
            foreach(var value in expectedValues)
            {
                queue.EnQueue(value);
            }

            //When
            //Then
            for (var i = 0; i < length; i++)
            {
                var actualValue = queue.DeQueue();
                var expectedValue = expectedValues[i];
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
