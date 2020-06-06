using DataStructures.DoubleEndedQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.DoubleEndedQueue
{
    [TestClass]
    public class DoubleEndedQueueV1Tests
    {
        [TestMethod]
        public void Given_QueueWithLengthFive_When_InsertFrontFiveTimes_Then_ValuesShouldBeAddedToQueue()
        {
            //Given
            var length = 5;
            var deadLetterQueue = new DoubleEndedQueueV1(length);
            var values = new List<int> { 1, 2, 3, 4, 5 };

            //When
            //Then
            foreach(var value in values)
            {
                deadLetterQueue.InsertFront(value);
            }
        }
    }
}
