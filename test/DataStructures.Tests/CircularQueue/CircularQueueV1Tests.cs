using DataStructures.CircularQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.CircularQueue
{
    [TestClass]
    public class CircularQueueV1Tests
    {
        [TestMethod]
        public void Given_CreateQueue_When_PerformsEnQueueAndDeQueue_Then()
        {
            //Given
            var length = 5;
            var queue = new CircularQueueV1(length);
            var expectedValues = new List<int> { 1, 2, 3, 4, 5 };
            foreach(var value in expectedValues)
            {
                queue.EnQueue(value);
            }

            //When
            //Then
            foreach (var expectedValue in expectedValues)
            {
                var actualValue = queue.DeQueue();
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
