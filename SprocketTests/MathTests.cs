using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprocket;

namespace SprocketTests
{
    [TestClass]
    public class MathTests
    {
        private Math _sut;

        [TestMethod]
        public void Sum_WhenZeros_GetZero()
        {
            // Arrange
            _sut = new Math(0, 0);

            // Act
            var result = _sut.Sum();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
