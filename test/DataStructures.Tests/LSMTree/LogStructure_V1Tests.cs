using DataStructures.LSMTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.LSMTree
{
    [TestClass]
    public class LogStructure_V1Tests
    {
        [TestMethod]
        public void Given_LogStructrureAndItems_When_MoreItemsAddedToLogStructureThanLimit_Then_ShouldPerformCompaction()
        {
            //Given
            var logStructure = new LogStructure_V1();
            var count = 10;

            //When
            while (count > 0)
            {
                var logCount = 10;
                while (logCount > 0)
                {
                    logStructure.Add(logCount, logCount.ToString());
                    logCount--;
                }
                count--;
            }

            //Then
            var items= logStructure.GetData();
        }
    }
}
