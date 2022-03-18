using NUnit.Framework;

namespace BloomFilter.Tests
{
    public class BloomFilterTests
    {
        [TestCase(null)]
        [TestCase(1234)]
        [TestCase("starwars")]
        public void ShouldReturnTrue_IfMatch(object target)
        {
            // Arrange
            var filter = new BloomFilter();
            filter.Add(target);

            // Act
            var actual = filter.Check(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestCase(null)]
        [TestCase(1234)]
        [TestCase("starwars")]
        public void ShouldReturnFalse_WhenNoMatch(object target)
        {
            // Arrange
            var filter = new BloomFilter();

            // Act
            var actual = filter.Check(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}