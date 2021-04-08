using DataStructures.CircularQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.CircularQueue
{
    [TestClass]
    public class CircularQueueV4Tests
    {
        [TestMethod]
        public void Given_CircualQueue_When_AddMoreItemsThanSizeOfCircualQueue_Then_ShouldThrowOverflowException()
        {
            //Given
            var length = 3;
            var circualQueue = new CircularQueueV4(length);
            //When
            //Then
            Assert.Fail();
        }
    }
}