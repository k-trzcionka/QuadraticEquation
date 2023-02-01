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

        [Theory]
        [InlineData(1, 2, 10)]
        [InlineData(2, 3, 5)]
        [InlineData(5, 4, 2)]
        public void CalculateRoots_NegativeTest(double a, double b, double c)
        {
            // Act
            double x1, x2;
            int numberOfRoots = Program.CalculateRoots(a, b, c, out x1, out x2);

            // Assert
            Assert.Equal(0, numberOfRoots);
        }

        [Theory]
        [InlineData(1, -4, 4, 2, 2)]
        [InlineData(2, -8, 8, 2, 2)]
        [InlineData(1, -2, 1, 1, 1)]
        public void CalculateRoots_OneRootTest(double a, double b, double c, double expectedX1, double expectedX2)
        {
            // Act
            double x1, x2;
            int numberOfRoots = Program.CalculateRoots(a, b, c, out x1, out x2);

            // Assert
            Assert.Equal(1, numberOfRoots);
            Assert.Equal(expectedX1, x1);
            Assert.Equal(expectedX2, x2);
        }
    }
}