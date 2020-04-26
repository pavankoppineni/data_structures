using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue.Tests
{
    [TestClass]
    public class SampleQueueTests
    {
        [TestMethod]
        public void GivenTwoItems_EnQueue_LengthShouldBeTwo()
        {
            //Arrange
            var size = 5;
            var sampleQueue = new SampleQueue(size);

            //Act
            sampleQueue.EnQueue(1);
            sampleQueue.EnQueue(2);

            //Assert
            Assert.AreEqual(2, sampleQueue.Length);
        }

        [TestMethod]
        public void GivenQueueWithFullCapacity_EnQueue_ThrowsOverflowException()
        {
            //Arrange
            var size = 5;
            var sampleQueue = new SampleQueue(size);
            sampleQueue.EnQueue(1);
            sampleQueue.EnQueue(2);
            sampleQueue.EnQueue(3);
            sampleQueue.EnQueue(4);
            sampleQueue.EnQueue(5);

            //Act
            Action action = () => sampleQueue.EnQueue(6);

            //Assert
            Assert.ThrowsException<OverflowException>(action);
        }

        [TestMethod]
        public void GivenQueueWithLengthFive_DeQueue_TwoItems_LengthShouldBeThree()
        {
            //Arrange
            var size = 5;
            var sampleQueue = new SampleQueue(size);
            sampleQueue.EnQueue(1);
            sampleQueue.EnQueue(2);
            sampleQueue.EnQueue(3);
            sampleQueue.EnQueue(4);
            sampleQueue.EnQueue(5);

            //Act
            sampleQueue.DeQueue();
            sampleQueue.DeQueue();

            //Assert
            Assert.AreEqual(3, sampleQueue.Length);
        }

        [TestMethod]
        public void GivenQueueWithLengthThree_DeQueue_FourItems_ThrowsIndexOutOfRangeException()
        {
            //Arrange
            var size = 3;
            var sampleQueue = new SampleQueue(size);
            sampleQueue.EnQueue(1);
            sampleQueue.EnQueue(2);
            sampleQueue.EnQueue(3);

            //Act
            sampleQueue.DeQueue();
            sampleQueue.DeQueue();
            sampleQueue.DeQueue();
            
            Action action = () => sampleQueue.DeQueue();

            //Assert
            Assert.ThrowsException<IndexOutOfRangeException>(action);
        }
    }
}
