
using FluentAssertions;

namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTests
    {
       
        [Theory]
        [InlineData (5,5,10)]
        [InlineData(5, 0, 5)]
        public void Add_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber,int secondNumber,int expectedResult)
        {
            Calculator calculator = new Calculator();
            int actualResult=calculator.Add(firstNumber, secondNumber);
            //Assert.Equal(10, actualResult);

            actualResult.Should().Be(expectedResult);

        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(5, 0, 5)]
        public void Subtraction_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            Calculator calculator = new Calculator();
            int actualResult = calculator.Subtraction(firstNumber, secondNumber);
            //Assert.Equal(10, actualResult);

            actualResult.Should().Be(expectedResult);

        }
    }
}