using System;
using Xunit;
using BinarySearch;

namespace BinarySearch.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnIndexTwo()
        {
            int[] testArray = { 4, 8, 15, 16, 23, 42 };
            int testSearchKey = 15;

            int sampleOutput = Program.BinarySearch(testArray, testSearchKey);

            Assert.Equal(2, sampleOutput);
        }

        [Fact]
        public void CanReturnNegativeOne()
        {
            int[] testArray = {11, 22, 33, 44, 55, 66, 77};
            int testSearchKey = 90;

            int sampleOutput = Program.BinarySearch(testArray, testSearchKey);

            Assert.Equal(-1, sampleOutput);
        }

        [Fact]
        public void ReturnNegativeOneWhenUnsortedArray()
        {
            int[] testArray = { 4, 8, 23, 16, 15, 42 };
            int testSearchKey = 15;

            int sampleOutput = Program.BinarySearch(testArray, testSearchKey);
            Assert.Equal(-1, sampleOutput);
        }
    }
}
