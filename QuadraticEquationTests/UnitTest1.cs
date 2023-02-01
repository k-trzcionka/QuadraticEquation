using QuadraticEquation;

namespace QuadraticEquation.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(1, -3, 2, 2, 1)]
        [InlineData(1, 5, 6, -2, -3)]
        [InlineData(2, 7, 6, -1.5, -2)]
        public void CalculateRoots_PositiveTests(double a, double b, double c, double expectedX1, double expectedX2)
        {
            // Act
            double x1, x2;
            int numberOfRoots = Program.CalculateRoots(a, b, c, out x1, out x2);
            // Assert
            Assert.Equal(2, numberOfRoots);
            Assert.Equal(expectedX1, x1);
            Assert.Equal(expectedX2, x2);
        }
    }
}