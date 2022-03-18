using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BloomFilter.Tests.PerformanceTests
{
    public class BloomFilterTests
    {
        private const int dataSize = 1_000_000; // 1 million
        private List<int> dataSet;

        [SetUp]
        public void SetUp()
        {
            dataSet = Enumerable.Range(0, dataSize).ToList();
        }

        [TestCase(0)]
        [TestCase(dataSize)]
        [TestCase(dataSize / 2)]
        [TestCase(-1)]
        public void ShouldReturnQuick(int targetNumber)
        {
            // Arrange
            var filter = new BloomFilter();
            dataSet.ForEach(x => filter.Add(x));

            // Act
            var actual = filter.Check(targetNumber);

            // Assert
        }
    }
}
