using Xunit;

namespace Calculator.Tests
{
    public class AverageCalculatorTests
    {
        [Fact]
        public void Calculates_Average()
        {
            //Arrange
            var sut = new AverageCalculator();
            var input = new[] { 5.0, 10.0, 15.0 };

            //Act
            var result = sut.CalculateAverage(input);

            //Assert
            Assert.Equal(10, result);
        }
    }
}
