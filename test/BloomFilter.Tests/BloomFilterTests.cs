using System;
using NUnit.Framework;

namespace BloomFilter.Tests
{
    public class BloomFilterTests
    {
        [TestCase(1234)]
        [TestCase("starwars")]
        public void ShouldReturnTrue_AsTheOnlyElement(object target)
        {
            // Arrange
            var filter = new BloomFilter();
            filter.Add(target);

            // Act
            var actual = filter.Check(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestCase(1234)]
        [TestCase("starwars")]
        public void ShouldReturnTrue_AsNotTheOnlyElement(object target)
        {
            // Arrange
            var filter = new BloomFilter();
            filter.Add(Guid.NewGuid());
            filter.Add(target);

            // Act
            var actual = filter.Check(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestCase(1234)]
        [TestCase("starwars")]
        public void ShouldReturnFalse_WhenNoElementsExists(object target)
        {
            // Arrange
            var filter = new BloomFilter();

            // Act
            var actual = filter.Check(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestCase(1234)]
        [TestCase("starwars")]
        public void ShouldReturnFalse_WhenNoMatchingElement(object target)
        {
            // Arrange
            var filter = new BloomFilter();
            filter.Add(Guid.NewGuid());

            // Act
            var actual = filter.Check(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}